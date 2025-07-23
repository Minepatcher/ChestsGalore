using ChestsGalore.Scripts.Components;
using HarmonyLib;

namespace ChestsGalore.Scripts.Patches
{
    [HarmonyPatch]
    public class CraftingBuildingPatch
    {
        [HarmonyPatch(typeof(CraftingBuilding), "GetCraftingUISettings")]
        [HarmonyPrefix]
        public static bool GetCraftingUISettings(CraftingBuilding __instance, ref CraftingBuilding.CraftingUISettings __result)
        {
            var objectId = __instance.objectData.objectID;
            var refresh = __instance.TryGetComponent(out RefreshCraftingUI refreshCraftingUI);
            if (!refresh || !refreshCraftingUI.refreshCraftingUI) return true;
            var window = Manager.ui.GetCraftingCategoryWindowInfo();
            if (window == null) return true;
            var index = Manager.ui.GetCraftingCategoryWindowInfos().FindIndex(win => win == window) - 1;
            __result = index == -1 ? new CraftingBuilding.CraftingUISettings(objectId, __instance.craftingUITitle, __instance.craftingUITitleLeftBox,
                __instance.craftingUITitleRightBox, __instance.craftingUIBackgroundVariation) : __instance.craftingUIOverrideSettings[index];
            return false;
        }
    }
}
