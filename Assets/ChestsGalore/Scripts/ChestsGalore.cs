using System.Collections.Generic;
using System.Linq;
using ChestsGalore.Scripts.Modifications;
using ChestsGalore.Scripts.Poolable;
using ChestsGalore.Scripts.ScriptableObjects;
using CoreLib;
using CoreLib.Localization;
using CoreLib.Submodules.ModEntity;
using CoreLib.Util.Extensions;
using PugMod;
using UnityEngine;
using Logger = CoreLib.Util.Logger;

namespace ChestsGalore.Scripts
{
    public class ChestsGalore : IMod
    {
        internal const string Version = "0.1.0";
        internal const string ModID = "ChestsGalore";
        internal const string FriendlyName = "Chests Galore";
        internal LoadedMod ModInfo;
        internal static readonly Logger Log = new (FriendlyName);
        internal static readonly List<GameObject> ChestGaloreEntities = new();
        internal static readonly List<ModObjectIDCategory>  ModObjectIDCategories = new();
        
        public void EarlyInit()
        {
            Log.LogInfo($"{FriendlyName} version: {Version}");
            CoreLibMod.LoadModules(
                typeof(EntityModule),
                typeof(LocalizationModule)
                );
            ModInfo = this.GetModInfo();
            if(ModInfo == null)
            {
                Log.LogInfo($"Failed to load {FriendlyName}: metadata not found!");
                return;
            }
            EntityModule.RegisterEntityModifications(typeof(ModModifications));
            EntityModule.RegisterEntityModifications(typeof(ChestModifications));
            EntityModule.RegisterEntityModifications(typeof(DoubleChestModifications));
            Localization.LocalizeAllTerms();
            Log.LogInfo($"{FriendlyName} loaded successfully");
        }

        public void Init()
        {
            foreach (var category in ModObjectIDCategories.ToList())
            {
                ObjectIDCategoryManager.Add(category.GetObjectIDCategory());
            }
        }

        public void Shutdown()
        {
        }

        public void ModObjectLoaded(Object obj)
        {
            if (obj is null) return;
            switch (obj)
            {
                case GameObject gameObject:
                    var isPoolableObject = gameObject.TryGetComponent(out PooledGraphicalObject pooledGraphicalObject);
                    if (isPoolableObject)
                        PooledGraphicalObjectConverter.Register(pooledGraphicalObject);
                    var hasObjectAuthoring = gameObject.TryGetComponent(out ObjectAuthoring objAuthoring);
                    if (hasObjectAuthoring)
                        ChestGaloreEntities.Add(gameObject);
                    break;
                case ModObjectIDCategory category:
                    ModObjectIDCategories.Add(category);
                    break;
            }
        }

        public void Update()
        {
        }
    }
}
