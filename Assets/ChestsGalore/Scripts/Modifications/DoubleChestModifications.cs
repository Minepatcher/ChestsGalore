using System.Collections.Generic;
using CoreLib.Submodules.ModEntity.Atributes;
using Unity.Entities;
using UnityEngine;

// ReSharper disable once CheckNamespace
namespace ChestsGalore.Scripts.Modifications
{
    [EntityModification]
    public static class DoubleChestModifications
    {
        /* Glurch Chest Modifications:
         - Change Recipe:
            - 1 Slime Boss Summoning Item
            - 5 Slime
            - 2 Ancient Gemstone
            - 4 Mechanical Part
         - Make Chest Salvageable
         */
        [EntityModification(ObjectID.GlurchChest)]
        private static void EditGlurchChest(Entity entity, GameObject authoring, EntityManager entityManager)
        {
            // Get Behavior Data
            EntityMonoBehaviourData chest = authoring.GetComponent<EntityMonoBehaviourData>();
            InventoryAuthoring inv = authoring.GetComponent<InventoryAuthoring>();
            if (chest is null || chest.objectInfo.variation != 0 || chest.objectInfo.requiredObjectsToCraft.Count > 1) return;
            if(inv is null || inv.itemsInInventory.Count > 0 || inv.addLootFromTable != LootTableID.Empty) return;
            
            // New Recipe
            List<CraftingObject> newList = new()
            {
                new CraftingObject
                {
                    objectID = ObjectID.SlimeBossSummoningItem,
                    amount = 1
                },
                new CraftingObject
                {
                    objectID = ObjectID.Slime,
                    amount = 5
                },
                new CraftingObject
                {
                    objectID = ObjectID.AncientGemstone,
                    amount = 2
                },
                new CraftingObject
                {
                    objectID = ObjectID.MechanicalPart,
                    amount = 4
                }
            };
            
            // Check and Set New Crafting Recipe and CanBeSalvaged Tag
            chest.objectInfo.requiredObjectsToCraft = newList;

            if(!chest.objectInfo.tags.Contains(ObjectCategoryTag.CanBeSalvaged))
                chest.objectInfo.tags.Add(ObjectCategoryTag.CanBeSalvaged);
        }
        /* King Slime Chest Modifications:
         - Change Recipe:
            - 1 King Slime Boss Summoning Item
            - 10 Slime
            - 2 Ancient Gemstone
            - 4 Mechanical Part
         - Make Chest Salvageable
         */
        [EntityModification(ObjectID.KingSlimeChest)]
        private static void EditKingSlimeChest(Entity entity, GameObject authoring, EntityManager entityManager)
        {
            // Get Behavior Data
            EntityMonoBehaviourData chest = authoring.GetComponent<EntityMonoBehaviourData>();
            InventoryAuthoring inv = authoring.GetComponent<InventoryAuthoring>();
            if (chest is null || chest.objectInfo.variation != 0 || chest.objectInfo.requiredObjectsToCraft.Count > 1) return;
            if(inv is null || inv.itemsInInventory.Count > 0 || inv.addLootFromTable != LootTableID.Empty) return;
            
            // New Recipe
            List<CraftingObject> newList = new()
            {
                new CraftingObject
                {
                    objectID = ObjectID.KingSlimeSummoningItem,
                    amount = 1
                },
                new CraftingObject
                {
                    objectID = ObjectID.Slime,
                    amount = 10
                },
                new CraftingObject
                {
                    objectID = ObjectID.AncientGemstone,
                    amount = 2
                },
                new CraftingObject
                {
                    objectID = ObjectID.MechanicalPart,
                    amount = 4
                }
            };
            
            // Check and Set New Crafting Recipe and CanBeSalvaged Tag
            chest.objectInfo.requiredObjectsToCraft = newList;

            if(!chest.objectInfo.tags.Contains(ObjectCategoryTag.CanBeSalvaged))
                chest.objectInfo.tags.Add(ObjectCategoryTag.CanBeSalvaged);
        }
        /* Ivy's Chest Modifications:
         - Change Recipe:
            - 1 Slime Boss Summoning Item
            - 5 Poison Slime
            - 2 Ancient Gemstone
            - 4 Mechanical Part
         - Make Chest Salvageable
         */
        [EntityModification(ObjectID.IvyChest)]
        private static void EditIvyChest(Entity entity, GameObject authoring, EntityManager entityManager)
        {
            // Get Behavior Data
            EntityMonoBehaviourData chest = authoring.GetComponent<EntityMonoBehaviourData>();
            InventoryAuthoring inv = authoring.GetComponent<InventoryAuthoring>();
            if (chest is null || chest.objectInfo.variation != 0 || chest.objectInfo.requiredObjectsToCraft.Count > 1) return;
            if(inv is null || inv.itemsInInventory.Count > 0 || inv.addLootFromTable != LootTableID.Empty) return;
            
            // New Recipe
            List<CraftingObject> newList = new()
            {
                new CraftingObject
                {
                    objectID = ObjectID.SlimeBossSummoningItem,
                    amount = 1
                },
                new CraftingObject
                {
                    objectID = ObjectID.PoisonSlime,
                    amount = 5
                },
                new CraftingObject
                {
                    objectID = ObjectID.AncientGemstone,
                    amount = 2
                },
                new CraftingObject
                {
                    objectID = ObjectID.MechanicalPart,
                    amount = 4
                }
            };
            
            // Check and Set New Crafting Recipe and CanBeSalvaged Tag
            chest.objectInfo.requiredObjectsToCraft = newList;

            if(!chest.objectInfo.tags.Contains(ObjectCategoryTag.CanBeSalvaged))
                chest.objectInfo.tags.Add(ObjectCategoryTag.CanBeSalvaged);
        }
        /* Morpha's Chest Modifications:
         - Change Recipe:
            - 1 Slime Boss Summoning Item
            - 5 Slippery Slime
            - 2 Ancient Gemstone
            - 4 Mechanical Part
         - Make Chest Salvageable
         */
        [EntityModification(ObjectID.MorphaChest)]
        private static void EditMorphaChest(Entity entity, GameObject authoring, EntityManager entityManager)
        {
            // Get Behavior Data
            EntityMonoBehaviourData chest = authoring.GetComponent<EntityMonoBehaviourData>();
            InventoryAuthoring inv = authoring.GetComponent<InventoryAuthoring>();
            if (chest is null || chest.objectInfo.variation != 0 || chest.objectInfo.requiredObjectsToCraft.Count > 1) return;
            if(inv is null || inv.itemsInInventory.Count > 0 || inv.addLootFromTable != LootTableID.Empty) return;
            
            // New Recipe
            List<CraftingObject> newList = new()
            {
                new CraftingObject
                {
                    objectID = ObjectID.SlimeBossSummoningItem,
                    amount = 1
                },
                new CraftingObject
                {
                    objectID = ObjectID.SlipperySlime,
                    amount = 5
                },
                new CraftingObject
                {
                    objectID = ObjectID.AncientGemstone,
                    amount = 2
                },
                new CraftingObject
                {
                    objectID = ObjectID.MechanicalPart,
                    amount = 4
                }
            };
            
            // Check and Set New Crafting Recipe and CanBeSalvaged Tag
            chest.objectInfo.requiredObjectsToCraft = newList;

            if(!chest.objectInfo.tags.Contains(ObjectCategoryTag.CanBeSalvaged))
                chest.objectInfo.tags.Add(ObjectCategoryTag.CanBeSalvaged);
        }
        /* Igneous's Chest Modifications:
         - Change Recipe:
            - 1 Slime Boss Summoning Item
            - 5 Lava Slime
            - 2 Ancient Gemstone
            - 4 Mechanical Part
         - Make Chest Salvageable
         */
        [EntityModification(ObjectID.LavaSlimeBossChest)]
        private static void EditIgneousChest(Entity entity, GameObject authoring, EntityManager entityManager)
        {
            // Get Behavior Data
            EntityMonoBehaviourData chest = authoring.GetComponent<EntityMonoBehaviourData>();
            InventoryAuthoring inv = authoring.GetComponent<InventoryAuthoring>();
            if (chest is null || chest.objectInfo.variation != 0 || chest.objectInfo.requiredObjectsToCraft.Count > 1) return;
            if(inv is null || inv.itemsInInventory.Count > 0 || inv.addLootFromTable != LootTableID.Empty) return;
            
            // New Recipe
            List<CraftingObject> newList = new()
            {
                new CraftingObject
                {
                    objectID = ObjectID.SlimeBossSummoningItem,
                    amount = 1
                },
                new CraftingObject
                {
                    objectID = ObjectID.LavaSlime,
                    amount = 5
                },
                new CraftingObject
                {
                    objectID = ObjectID.AncientGemstone,
                    amount = 2
                },
                new CraftingObject
                {
                    objectID = ObjectID.MechanicalPart,
                    amount = 4
                }
            };
            
            // Check and Set New Crafting Recipe and CanBeSalvaged Tag
            chest.objectInfo.requiredObjectsToCraft = newList;

            if(!chest.objectInfo.tags.Contains(ObjectCategoryTag.CanBeSalvaged))
                chest.objectInfo.tags.Add(ObjectCategoryTag.CanBeSalvaged);
        }
    }
}