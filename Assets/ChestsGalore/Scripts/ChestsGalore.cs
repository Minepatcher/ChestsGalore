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
        private const string Version = "0.3.0";
        internal const string ModID = "ChestsGalore";
        private const string FriendlyName = "Chests Galore";
        private LoadedMod _modInfo;
        private static readonly Logger Log = new (FriendlyName);
        
        public void EarlyInit()
        {
            Log.LogInfo($"v{Version}");
            CoreLibMod.LoadSubmodule(typeof(EntityModule));
            _modInfo = this.GetModInfo();
            if (_modInfo == null)
            {
                Log.LogError($"Failed to load {FriendlyName}: metadata not found!");
            }
        }

        public void Init()
        {
            if (ScriptableData.TryGetDataBlock(new DataBlockAddress("c390e528-719a-b304-4a95-11c0c4566a6c"),
                    out ObjectIDCategoryDataBlock chestCategoryBlock))
            {
                chestCategoryBlock.Add(API.Authoring.GetObjectID("ChestsGalore:MagicChest"));
            }
            if (ScriptableData.TryGetDataBlock(new DataBlockAddress("c2635c2a-f081-4a83-a448-c7facfa173c1"),
                    out ObjectIDCategoryDataBlock workbenchCategoryBlock))
            {
                workbenchCategoryBlock.Add(API.Authoring.GetObjectID("ChestsGalore:WorkbenchChest"));
                workbenchCategoryBlock.Add(API.Authoring.GetObjectID("ChestsGalore:WorkbenchDoubleChest"));
                workbenchCategoryBlock.Add(API.Authoring.GetObjectID("ChestsGalore:WorkbenchMagicChest"));
            }
            Log.LogInfo($"Loaded Successfully...");
        }

        public void Shutdown() { }

        public void ModObjectLoaded(Object obj) { }

        public void Update() { }
    }
}