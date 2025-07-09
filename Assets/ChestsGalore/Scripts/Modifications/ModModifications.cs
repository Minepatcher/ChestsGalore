using System.Collections.Generic;
using System.Linq;
using CoreLib.Submodules.ModEntity.Atributes;
using CoreLib.Util.Extensions;
using PugMod;
using Unity.Entities;
using UnityEngine;

// ReSharper disable once CheckNamespace
namespace ChestsGalore.Scripts.Modifications
{
    [EntityModification]
    public class ModModifications
    {
        internal static ObjectIDCategory Workbenches = ObjectIDCategoryManager.SubCategories.ToList().Find(x => x.name == "ChestsGaloreMod_Workbench");
        internal static ObjectIDCategory Chests = ObjectIDCategoryManager.SubCategories.ToList().Find(x => x.name == "ChestsGaloreMod_Chest");
        
        [EntityModification(ObjectID.Player)]
        private static void EditPlayer(Entity entity, GameObject authoring, EntityManager entityManager)
        {
            List<CraftingAuthoring.CraftableObject> crafting = authoring.GetComponent<CraftingAuthoring>().canCraftObjects;
            ObjectID objectID = API.Authoring.GetObjectID("ChestsGalore:WorkbenchChest");
            if (crafting.FindIndex(x => x.objectID == objectID) == -1)
            {
                crafting.Add(new CraftingAuthoring.CraftableObject
                {
                    objectID = objectID,
                    amount = 1
                });
            }
        }
        [EntityModification("ChestsGalore:WorkbenchChest")]
        private static void EditWorkbenchChest(Entity entity, GameObject authoring, EntityManager entityManager)
        {
            ObjectID objectID = authoring.GetEntityObjectID();
            if (objectID == ObjectID.None) return;
            if (Workbenches.Contains(objectID)) return;
            Workbenches.Add(objectID);
            ObjectIDCategoryManager.Add(Workbenches);
        }
        [EntityModification("ChestsGalore:WorkbenchDoubleChest")]
        private static void EditWorkbenchDoubleChest(Entity entity, GameObject authoring, EntityManager entityManager)
        {
            ObjectID objectID = authoring.GetEntityObjectID();
            if (objectID == ObjectID.None) return;
            if (Workbenches.Contains(objectID)) return;
            Workbenches.Add(objectID);
            ObjectIDCategoryManager.Add(Workbenches);
        }
        [EntityModification("ChestsGalore:WorkbenchMagicChest")]
        private static void EditWorkbenchMagicChest(Entity entity, GameObject authoring, EntityManager entityManager)
        {
            ObjectID objectID = authoring.GetEntityObjectID();
            if (objectID == ObjectID.None) return;
            if (Workbenches.Contains(objectID)) return;
            Workbenches.Add(objectID);
            ObjectIDCategoryManager.Add(Workbenches);
        }
        [EntityModification("ChestsGalore:MagicChest")]
        private static void EditMagicChest(Entity entity, GameObject authoring, EntityManager entityManager)
        {
            ObjectID objectID = authoring.GetEntityObjectID();
            if (objectID == ObjectID.None) return;
            if (Chests.Contains(objectID)) return;
            Chests.Add(objectID);
            ObjectIDCategoryManager.Add(Chests);
        }
    }
}