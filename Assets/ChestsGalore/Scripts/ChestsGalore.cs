using System.Collections.Generic;
using ChestsGalore.Scripts.Modifications;
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
        internal const string Version = "0.0.1";
        internal const string ModID = "ChestsGalore";
        internal const string FriendlyName = "Chests Galore";
        internal LoadedMod ModInfo;
        internal static readonly Logger Log = new (FriendlyName);
        internal static readonly List<GameObject> ModChestWorkbenches = new();
        
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
            // Register single type
            EntityModule.RegisterEntityModifications(typeof(ModModifications));
            EntityModule.RegisterEntityModifications(typeof(ChestModifications));
            EntityModule.RegisterEntityModifications(typeof(DoubleChestModifications));
            Localization.LocalizeAllTerms();
            Log.LogInfo($"{FriendlyName} loaded successfully");
        }

        public void Init()
        {
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
                    EntityMonoBehaviour entityMono = gameObject.GetComponent<EntityMonoBehaviour>();
                    if (entityMono is not null) EntityModule.EnablePooling(gameObject);
                    ObjectAuthoring objAuthoring = gameObject.GetComponent<ObjectAuthoring>();
                    if (objAuthoring is not null)
                    {
                        if (objAuthoring.objectName.Contains("ChestsGalore:Workbench"))
                            ModChestWorkbenches.Add(gameObject);
                        EntityModule.AddEntity(objAuthoring.objectName, objAuthoring);
                        EntityModule.AddToAuthoringList(gameObject);
                    }
                    break;
            }
        }

        public void Update()
        {
        }
    }
}
