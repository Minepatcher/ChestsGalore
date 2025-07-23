using System.Collections.Generic;
using CoreLib.Submodules.ModEntity.Atributes;
using Unity.Entities;
using UnityEngine;

namespace ChestsGalore.Scripts.Modifications
{
    [EntityModification]
    public static class ChestModifications
    {
        /* Chest */ [EntityModification(ObjectID.InventoryChest)]
        private static void EditChest(Entity entity, GameObject authoring, EntityManager entityManager)
        {
            // Get Behavior Data
            var chest = authoring.GetComponent<EntityMonoBehaviourData>();
            var inv = authoring.GetComponent<InventoryAuthoring>();
            if (chest is null || chest.objectInfo.variation != 0 || chest.objectInfo.requiredObjectsToCraft.Count > 1) return;
            if(inv is null || inv.itemsInInventory.Count > 0 || inv.addLootFromTable != LootTableID.Empty) return;
            // Check and Set CanBeSalvaged Tag
            if(!chest.objectInfo.tags.Contains(ObjectCategoryTag.CanBeSalvaged))
                chest.objectInfo.tags.Add(ObjectCategoryTag.CanBeSalvaged);
        }
        /* Copper Chest */ [EntityModification(ObjectID.CopperChest)]
        private static void EditCopperChest(Entity entity, GameObject authoring, EntityManager entityManager)
        {
            // Get Behavior Data
            var chest = authoring.GetComponent<EntityMonoBehaviourData>();
            var inv = authoring.GetComponent<InventoryAuthoring>();
            if (chest is null || chest.objectInfo.variation != 0 || chest.objectInfo.requiredObjectsToCraft.Count > 1) return;
            if(inv is null || inv.itemsInInventory.Count > 0 || inv.addLootFromTable != LootTableID.Empty) return;
            // New Recipe
            var newList = new List<CraftingObject>{
                new() { objectID = ObjectID.CopperBar, amount = 5 },
                new() { objectID = ObjectID.Wood, amount = 5 }
            };
            // Check and Set New Crafting Recipe and CanBeSalvaged Tag
            chest.objectInfo.requiredObjectsToCraft = newList;
            if(!chest.objectInfo.tags.Contains(ObjectCategoryTag.CanBeSalvaged))
                chest.objectInfo.tags.Add(ObjectCategoryTag.CanBeSalvaged);
        }
        /* Iron Chest */ [EntityModification(ObjectID.IronChest)]
        private static void EditIronChest(Entity entity, GameObject authoring, EntityManager entityManager)
        {
            // Get Behavior Data
            var chest = authoring.GetComponent<EntityMonoBehaviourData>();
            var inv = authoring.GetComponent<InventoryAuthoring>();
            if (chest is null || chest.objectInfo.variation != 0 || chest.objectInfo.requiredObjectsToCraft.Count > 1) return;
            if(inv is null || inv.itemsInInventory.Count > 0 || inv.addLootFromTable != LootTableID.Empty) return;
            // New Recipe
            var newList = new List<CraftingObject>{
                new() { objectID = ObjectID.IronBar, amount = 5 },
                new() { objectID = ObjectID.Wood, amount = 5 }
            };
            // Check and Set New Crafting Recipe and CanBeSalvaged Tag
            chest.objectInfo.requiredObjectsToCraft = newList;
            if(!chest.objectInfo.tags.Contains(ObjectCategoryTag.CanBeSalvaged))
                chest.objectInfo.tags.Add(ObjectCategoryTag.CanBeSalvaged);
        }
        /* Scarlet Chest */ [EntityModification(ObjectID.ScarletChest)]
        private static void EditScarletChest(Entity entity, GameObject authoring, EntityManager entityManager)
        {
            // Get Behavior Data
            var chest = authoring.GetComponent<EntityMonoBehaviourData>();
            var inv = authoring.GetComponent<InventoryAuthoring>();
            if (chest is null || chest.objectInfo.variation != 0 || chest.objectInfo.requiredObjectsToCraft.Count > 1) return;
            if(inv is null || inv.itemsInInventory.Count > 0 || inv.addLootFromTable != LootTableID.Empty) return;
            // New Recipe
            var newList = new List<CraftingObject>{
                new() { objectID = ObjectID.ScarletBar, amount = 5 },
                new() { objectID = ObjectID.Wood, amount = 5 }
            };
            // Check and Set New Crafting Recipe and CanBeSalvaged Tag
            chest.objectInfo.requiredObjectsToCraft = newList;
            if(!chest.objectInfo.tags.Contains(ObjectCategoryTag.CanBeSalvaged))
                chest.objectInfo.tags.Add(ObjectCategoryTag.CanBeSalvaged);
        }
        /* Octarine Chest */ [EntityModification(ObjectID.OctarineChest)]
        private static void EditOctarineChest(Entity entity, GameObject authoring, EntityManager entityManager)
        {
            // Get Behavior Data
            var chest = authoring.GetComponent<EntityMonoBehaviourData>();
            var inv = authoring.GetComponent<InventoryAuthoring>();
            if (chest is null || chest.objectInfo.variation != 0 || chest.objectInfo.requiredObjectsToCraft.Count > 1) return;
            if(inv is null || inv.itemsInInventory.Count > 0 || inv.addLootFromTable != LootTableID.Empty) return;
            // New Recipe
            var newList = new List<CraftingObject>{
                new() { objectID = ObjectID.OctarineBar, amount = 5 },
                new() { objectID = ObjectID.CoralWood, amount = 5 }
            };
            // Check and Set New Crafting Recipe and CanBeSalvaged Tag
            chest.objectInfo.requiredObjectsToCraft = newList;
            if(!chest.objectInfo.tags.Contains(ObjectCategoryTag.CanBeSalvaged))
                chest.objectInfo.tags.Add(ObjectCategoryTag.CanBeSalvaged);
        }
        /* Galaxite Chest */ [EntityModification(ObjectID.GalaxiteChest)]
        private static void EditGalaxiteChest(Entity entity, GameObject authoring, EntityManager entityManager)
        {
            // Get Behavior Data
            var chest = authoring.GetComponent<EntityMonoBehaviourData>();
            var inv = authoring.GetComponent<InventoryAuthoring>();
            if (chest is null || chest.objectInfo.variation != 0 || chest.objectInfo.requiredObjectsToCraft.Count > 1) return;
            if(inv is null || inv.itemsInInventory.Count > 0 || inv.addLootFromTable != LootTableID.Empty) return;
            // New Recipe
            var newList = new List<CraftingObject>{
                new() { objectID = ObjectID.GalaxiteBar, amount = 5 },
                new() { objectID = ObjectID.CoralWood, amount = 5 }
            };
            // Check and Set New Crafting Recipe and CanBeSalvaged Tag
            chest.objectInfo.requiredObjectsToCraft = newList;
            if(!chest.objectInfo.tags.Contains(ObjectCategoryTag.CanBeSalvaged))
                chest.objectInfo.tags.Add(ObjectCategoryTag.CanBeSalvaged);
        }
        /* Solarite Chest */ [EntityModification(ObjectID.SolariteChest)]
        private static void EditSolariteChest(Entity entity, GameObject authoring, EntityManager entityManager)
        {
            // Get Behavior Data
            var chest = authoring.GetComponent<EntityMonoBehaviourData>();
            var inv = authoring.GetComponent<InventoryAuthoring>();
            if (chest is null || chest.objectInfo.variation != 0 || chest.objectInfo.requiredObjectsToCraft.Count > 1) return;
            if(inv is null || inv.itemsInInventory.Count > 0 || inv.addLootFromTable != LootTableID.Empty) return;
            // New Recipe
            var newList = new List<CraftingObject>{
                new() { objectID = ObjectID.SolariteBar, amount = 5 },
                new() { objectID = ObjectID.GleamWood, amount = 5 }
            };
            // Check and Set New Crafting Recipe and CanBeSalvaged Tag
            chest.objectInfo.requiredObjectsToCraft = newList;
            if(!chest.objectInfo.tags.Contains(ObjectCategoryTag.CanBeSalvaged))
                chest.objectInfo.tags.Add(ObjectCategoryTag.CanBeSalvaged);
        }
        /* Ancient Chest */ [EntityModification(ObjectID.InventoryAncientChest)]
        private static void EditAncientChest(Entity entity, GameObject authoring, EntityManager entityManager)
        {
            // Get Behavior Data
            var chest = authoring.GetComponent<EntityMonoBehaviourData>();
            var inv = authoring.GetComponent<InventoryAuthoring>();
            if (chest is null || chest.objectInfo.variation != 0 || chest.objectInfo.requiredObjectsToCraft.Count > 1) return;
            if(inv is null || inv.itemsInInventory.Count > 0 || inv.addLootFromTable != LootTableID.Empty) return;
            // New Recipe
            var newList = new List<CraftingObject>{
                new() { objectID = ObjectID.WallCityBlock, amount = 3 },
                new() { objectID = ObjectID.IronBar, amount = 2 },
                new() { objectID = ObjectID.AncientGemstone, amount = 1 },
                new() { objectID = ObjectID.MechanicalPart, amount = 2 }
            };
            // Check and Set New Crafting Recipe and CanBeSalvaged Tag
            chest.objectInfo.requiredObjectsToCraft = newList;
            if(!chest.objectInfo.tags.Contains(ObjectCategoryTag.CanBeSalvaged))
                chest.objectInfo.tags.Add(ObjectCategoryTag.CanBeSalvaged);
        }
        /* Golden Ancient Chest */ [EntityModification(ObjectID.InventoryDesertBiomeChest)]
        private static void EditGoldenAncientChest(Entity entity, GameObject authoring, EntityManager entityManager)
        {
            // Get Behavior Data
            var chest = authoring.GetComponent<EntityMonoBehaviourData>();
            var inv = authoring.GetComponent<InventoryAuthoring>();
            if (chest is null || chest.objectInfo.variation != 0 || chest.objectInfo.requiredObjectsToCraft.Count > 1) return;
            if(inv is null || inv.itemsInInventory.Count > 0 || inv.addLootFromTable != LootTableID.Empty) return;
            // New Recipe
            var newList = new List<CraftingObject>{
                new() { objectID = ObjectID.WallDesertTempleBlock, amount = 3 },
                new() { objectID = ObjectID.GoldBar, amount = 2 },
                new() { objectID = ObjectID.AncientGemstone, amount = 1 },
                new() { objectID = ObjectID.MechanicalPart, amount = 2 }
            };
            // Check and Set New Crafting Recipe and CanBeSalvaged Tag
            chest.objectInfo.requiredObjectsToCraft = newList;
            if(!chest.objectInfo.tags.Contains(ObjectCategoryTag.CanBeSalvaged))
                chest.objectInfo.tags.Add(ObjectCategoryTag.CanBeSalvaged);
        }
        /* Alien Chest */ [EntityModification(ObjectID.AlienChest)]
        private static void EditAlienChest(Entity entity, GameObject authoring, EntityManager entityManager)
        {
            // Get Behavior Data
            var chest = authoring.GetComponent<EntityMonoBehaviourData>();
            var inv = authoring.GetComponent<InventoryAuthoring>();
            if (chest is null || chest.objectInfo.variation != 0 || chest.objectInfo.requiredObjectsToCraft.Count > 1) return;
            if(inv is null || inv.itemsInInventory.Count > 0 || inv.addLootFromTable != LootTableID.Empty) return;
            // New Recipe
            var newList = new List<CraftingObject>{
                new() { objectID = ObjectID.WallAlienBlock, amount = 3 },
                new() { objectID = ObjectID.PandoriumBar, amount = 2 },
                new() { objectID = ObjectID.AncientGemstone, amount = 2 },
                new() { objectID = ObjectID.MechanicalPart, amount = 2 }
            };
            // Check and Set New Crafting Recipe and CanBeSalvaged Tag
            chest.objectInfo.requiredObjectsToCraft = newList;
            if(!chest.objectInfo.tags.Contains(ObjectCategoryTag.CanBeSalvaged))
                chest.objectInfo.tags.Add(ObjectCategoryTag.CanBeSalvaged);
        }
        /* Cultist Chest */ [EntityModification(ObjectID.PassageChest)]
        private static void EditCultistChest(Entity entity, GameObject authoring, EntityManager entityManager)
        {
            // Get Behavior Data
            var chest = authoring.GetComponent<EntityMonoBehaviourData>();
            var inv = authoring.GetComponent<InventoryAuthoring>();
            if (chest is null || chest.objectInfo.variation != 0 || chest.objectInfo.requiredObjectsToCraft.Count > 1) return;
            if(inv is null || inv.itemsInInventory.Count > 0 || inv.addLootFromTable != LootTableID.Empty) return;
            // New Recipe
            var newList = new List<CraftingObject>{
                new() { objectID = ObjectID.WallPassageBlock, amount = 2 },
                new() { objectID = ObjectID.PandoriumBar, amount = 5 },
                new() { objectID = ObjectID.AncientGemstone, amount = 1 },
                new() { objectID = ObjectID.MechanicalPart, amount = 2 }
            };
            // Check and Set New Crafting Recipe and CanBeSalvaged Tag
            chest.objectInfo.requiredObjectsToCraft = newList;
            if(!chest.objectInfo.tags.Contains(ObjectCategoryTag.CanBeSalvaged))
                chest.objectInfo.tags.Add(ObjectCategoryTag.CanBeSalvaged);
        }
        /* Larva Hive Chest */ [EntityModification(ObjectID.InventoryLarvaHiveChest)]
        private static void EditLarvaHiveChest(Entity entity, GameObject authoring, EntityManager entityManager)
        {
            // Get Behavior Data
            var chest = authoring.GetComponent<EntityMonoBehaviourData>();
            var inv = authoring.GetComponent<InventoryAuthoring>();
            if (chest is null || chest.objectInfo.variation != 0 || chest.objectInfo.requiredObjectsToCraft.Count > 1) return;
            if(inv is null || inv.itemsInInventory.Count > 0 || inv.addLootFromTable != LootTableID.Empty) return; 
            // New Recipe
            var newList = new List<CraftingObject>{
                new() { objectID = ObjectID.WallHiveBlock, amount = 3 },
                new() { objectID = ObjectID.WallClayBlock, amount = 2 },
                new() { objectID = ObjectID.Fiber, amount = 2 },
                new() { objectID = ObjectID.MechanicalPart, amount = 2 }
            };
            // Check and Set New Crafting Recipe and CanBeSalvaged Tag
            chest.objectInfo.requiredObjectsToCraft = newList;
            if(!chest.objectInfo.tags.Contains(ObjectCategoryTag.CanBeSalvaged))
                chest.objectInfo.tags.Add(ObjectCategoryTag.CanBeSalvaged);
        }
        /* Mold Covered Chest */ [EntityModification(ObjectID.InventoryMoldDungeonChest)]
        private static void EditMoldCoveredChest(Entity entity, GameObject authoring, EntityManager entityManager)
        {
            // Get Behavior Data
            var chest = authoring.GetComponent<EntityMonoBehaviourData>();
            var inv = authoring.GetComponent<InventoryAuthoring>();
            if (chest is null || chest.objectInfo.variation != 0 || chest.objectInfo.requiredObjectsToCraft.Count > 1) return;
            if(inv is null || inv.itemsInInventory.Count > 0 || inv.addLootFromTable != LootTableID.Empty) return;
            // New Recipe
            var newList = new List<CraftingObject>{
                new() { objectID = ObjectID.WallMoldBlock, amount = 3 },
                new() { objectID = ObjectID.IronBar, amount = 2 },
                new() { objectID = ObjectID.MoldDestructible, amount = 1 },
                new() { objectID = ObjectID.MechanicalPart, amount = 2 }
            };
            // Check and Set New Crafting Recipe and CanBeSalvaged Tag
            chest.objectInfo.requiredObjectsToCraft = newList;
            if(!chest.objectInfo.tags.Contains(ObjectCategoryTag.CanBeSalvaged))
                chest.objectInfo.tags.Add(ObjectCategoryTag.CanBeSalvaged);
        }
        /* Seashell Chest */ [EntityModification(ObjectID.InventorySeaBiomeChest)]
        private static void EditSeashellChest(Entity entity, GameObject authoring, EntityManager entityManager)
        {
            // Get Behavior Data
            var chest = authoring.GetComponent<EntityMonoBehaviourData>();
            var inv = authoring.GetComponent<InventoryAuthoring>();
            if (chest is null || chest.objectInfo.variation != 0 || chest.objectInfo.requiredObjectsToCraft.Count > 1) return;
            if(inv is null || inv.itemsInInventory.Count > 0 || inv.addLootFromTable != LootTableID.Empty) return;
            // New Recipe
            var newList = new List<CraftingObject>{
                new() { objectID = ObjectID.WallLimestoneBlock, amount = 2 },
                new() { objectID = ObjectID.SeaShell, amount = 5 },
                new() { objectID = ObjectID.MechanicalPart, amount = 2 }
            };
            // Check and Set New Crafting Recipe and CanBeSalvaged Tag
            chest.objectInfo.requiredObjectsToCraft = newList;
            if(!chest.objectInfo.tags.Contains(ObjectCategoryTag.CanBeSalvaged))
                chest.objectInfo.tags.Add(ObjectCategoryTag.CanBeSalvaged);
        }
        /* Smoldering Chest */ [EntityModification(ObjectID.InventoryLavaChest)]
        private static void EditSmolderingChest(Entity entity, GameObject authoring, EntityManager entityManager)
        {
            // Get Behavior Data
            var chest = authoring.GetComponent<EntityMonoBehaviourData>();
            var inv = authoring.GetComponent<InventoryAuthoring>();
            if (chest is null || chest.objectInfo.variation != 0 || chest.objectInfo.requiredObjectsToCraft.Count > 1) return;
            if(inv is null || inv.itemsInInventory.Count > 0 || inv.addLootFromTable != LootTableID.Empty) return;
            // New Recipe
            var newList = new List<CraftingObject>{
                new() { objectID = ObjectID.WallLavaBlock, amount = 5 },
                new() { objectID = ObjectID.LavaSlime, amount = 2 },
                new() { objectID = ObjectID.MechanicalPart, amount = 2 }
            };
            // Check and Set New Crafting Recipe and CanBeSalvaged Tag
            chest.objectInfo.requiredObjectsToCraft = newList;
            if(!chest.objectInfo.tags.Contains(ObjectCategoryTag.CanBeSalvaged))
                chest.objectInfo.tags.Add(ObjectCategoryTag.CanBeSalvaged);
        }
    }
}