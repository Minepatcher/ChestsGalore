using System.Collections.Generic;
using System.Linq;
using CoreLib.Util.Extensions;
using HarmonyLib;

namespace ChestsGalore.Scripts.Patches
{
    [HarmonyPatch]
    public class CreativeCategoryFilterPatch
    {
        [HarmonyPatch(typeof(CraftingSelectorFilterCategoryUI), "Awake")]
        [HarmonyPrefix]
        public static bool OnAwakeOfCategory(CraftingSelectorFilterCategoryUI __instance)
        {
            var pass = false;
            var currCategories = __instance.GetValue<List<ObjectIDCategory>>("categories");
            List<ObjectIDCategory> newCategories = new();
            switch (__instance.gameObject.name)
            {
                case "CategoryFilter":
                    newCategories = ObjectIDCategoryManager.ParentCategories.ToList();
                    break;
                case "SubCategoryFilter":
                    newCategories = ObjectIDCategoryManager.SubCategories.ToList();
                    break;
            }
            foreach (var newCategory in newCategories.FindAll(x => x.name.Contains(ChestsGalore.ModID)))
            {
                if (currCategories.Contains(newCategory)) continue;
                currCategories.Add(newCategory);
                pass = true;
            }
            if(pass) __instance.SetValue("categories", currCategories);
            return true;
        }
    }
}
