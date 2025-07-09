using CoreLib.Util.Extensions;
using HarmonyLib;
using UnityEngine;

// ReSharper disable InconsistentNaming
namespace ChestsGalore.Scripts.Patches
{
    [HarmonyPatch]
    public class CraftingBuildingPatch
    {
        [HarmonyPatch(typeof(CraftingBuilding), "GetCraftingUISettings")]
        [HarmonyPrefix]
        public static bool GetCraftingUISettings(CraftingBuilding __instance, ref CraftingBuilding.CraftingUISettings __result)
        {
            ObjectID objectId = __instance.objectData.objectID;
            
            GameObject workbench = ChestsGalore.ModChestWorkbenches.Find(definition =>
                definition.GetEntityObjectID() == objectId);
            if (workbench is null) return true;
            CraftingBuilding.CraftingCategoryWindowInfo window = Manager.ui.GetCraftingCategoryWindowInfo();
            if (window == null) return true;
            int index = Manager.ui.GetCraftingCategoryWindowInfos().FindIndex(win => win == window) - 1;
            __result = index == -1 ? new CraftingBuilding.CraftingUISettings(objectId, __instance.craftingUITitle, __instance.craftingUITitleLeftBox,
                __instance.craftingUITitleRightBox, __instance.craftingUIBackgroundVariation) : __instance.craftingUIOverrideSettings[index];
            return false;
        }
    }
}
