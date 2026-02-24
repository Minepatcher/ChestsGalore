using System.Collections.Generic;
using System.Linq;
using ChestsGalore.Scripts.ScriptableObjects;
using CoreLib;
using CoreLib.Submodule.Entity;
using CoreLib.Util.Extension;
using PugMod;
using UnityEngine;
using Logger = CoreLib.Util.Logger;

namespace ChestsGalore.Scripts
{
    public class ChestsGalore : IMod
    {
        private const string Version = "0.1.0";
        internal const string ModID = "ChestsGalore";
        private const string FriendlyName = "Chests Galore";
        private LoadedMod _modInfo;
        private static readonly Logger Log = new (FriendlyName);
        private static readonly List<ModObjectIDCategory>  ModObjectIDCategories = new();
        private static readonly List<ObjectIDCategory> ObjectIDCategories = new();
        
        public void EarlyInit()
        {
            Log.LogInfo($"{FriendlyName} version: {Version}");
            CoreLibMod.LoadSubmodule(typeof(EntityModule));
            _modInfo = this.GetModInfo();
            if (_modInfo == null)
            {
                Log.LogError($"Failed to load {FriendlyName}: metadata not found!");
                return;
            }
            ModObjectIDCategories.AddRange(_modInfo.Assets.OfType<ModObjectIDCategory>());
        }

        public void Init()
        {
            Log.LogInfo($"{FriendlyName} Initialize");
            foreach (var category in ModObjectIDCategories)
            {
                var objCategory = category.GetObjectIDCategory();
                ObjectIDCategories.Add(objCategory);
                ObjectIDCategoryManager.Add(objCategory);
            }
            var craftingSelectorUI = Manager.ui.creativeModeUI;
            var categoryFilters = craftingSelectorUI.GetComponentsInChildren<CraftingSelectorFilterCategoryUI>(true);
            foreach (var filter in categoryFilters)
            {
                var currCategories = filter.GetValue<List<ObjectIDCategory>>("categories");
                List<ObjectIDCategory> newCategories = new();
                switch (filter.gameObject.name)
                {
                    case "CategoryFilter":
                        newCategories = ObjectIDCategories.Where(x => !x.name.Contains('_')).ToList();
                        break;
                    case "SubCategoryFilter":
                        newCategories = ObjectIDCategories.Where(x => x.name.Contains('_')).ToList();
                        break;
                }
                currCategories.AddRange(newCategories);
                filter.SetValue("categories", currCategories);
            }
            Log.LogInfo($"{FriendlyName} loaded successfully");
        }

        public void Shutdown() { }

        public void ModObjectLoaded(Object obj) { }

        public void Update() { }
    }
}