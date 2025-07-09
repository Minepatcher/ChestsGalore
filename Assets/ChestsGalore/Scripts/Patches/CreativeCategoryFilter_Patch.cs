using System.Collections.Generic;
using System.Linq;
using CoreLib.Util.Extensions;
using HarmonyLib;

// ReSharper disable InconsistentNaming
namespace ChestsGalore.Scripts.Patches
{
    [HarmonyPatch]
    public class CreativeCategoryFilterPatch
    {
        [HarmonyPatch(typeof(CraftingSelectorFilterCategoryUI), "Awake")]
        [HarmonyPrefix]
        public static bool OnAwakeOfCategory(CraftingSelectorFilterCategoryUI __instance)
        {
            switch (__instance.gameObject.name)
            {
                case "CategoryFilter":
                    List<ObjectIDCategory> parentCategories = __instance.GetValue<List<ObjectIDCategory>>("categories");
                    ObjectIDCategory chestsGaloreMod = ObjectIDCategoryManager.ParentCategories.ToList()
                        .Find(x => x.name == "ChestsGaloreMod");
                    if (!parentCategories.Contains(chestsGaloreMod))
                    {
                        parentCategories.Add(chestsGaloreMod);
                        __instance.SetValue("categories", parentCategories);
                    }
                    break;
                case "SubCategoryFilter":
                    bool pass = false;
                    List<ObjectIDCategory> subCategories = __instance.GetValue<List<ObjectIDCategory>>("categories");
                    ObjectIDCategory chests = ObjectIDCategoryManager.SubCategories.ToList()
                        .Find(x => x.name == "ChestsGaloreMod_Chest");
                    ObjectIDCategory workbenches = ObjectIDCategoryManager.SubCategories.ToList()
                        .Find(x => x.name == "ChestsGaloreMod_Workbench");
                    if (!subCategories.Contains(chests))
                    {
                        subCategories.Add(chests);
                        pass = true;
                    }
                    if (!subCategories.Contains(workbenches))
                    {
                        subCategories.Add(workbenches);
                        pass = true;
                    }
                    if(pass) __instance.SetValue("categories", subCategories);
                    break;
            }
            return true;
        }
    }
}
