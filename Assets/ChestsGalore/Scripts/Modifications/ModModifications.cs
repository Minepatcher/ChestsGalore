using CoreLib.Submodules.ModEntity.Atributes;
using PugMod;
using Unity.Entities;
using UnityEngine;

namespace ChestsGalore.Scripts.Modifications
{
    [EntityModification]
    public class ModModifications
    {
        [EntityModification(ObjectID.Player)]
        private static void EditPlayer(Entity entity, GameObject authoring, EntityManager entityManager)
        {
            var crafting = authoring.GetComponent<CraftingAuthoring>().canCraftObjects;
            var objectID = API.Authoring.GetObjectID("ChestsGalore:WorkbenchChest");
            if (crafting.FindIndex(x => x.objectID == objectID) == -1) 
                crafting.Add(new CraftingAuthoring.CraftableObject { objectID = objectID, amount = 1 });
        }
    }
}