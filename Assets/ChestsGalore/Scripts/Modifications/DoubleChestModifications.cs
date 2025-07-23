using System.Collections.Generic;
using CoreLib.Submodules.ModEntity.Atributes;
using Unity.Entities;
using UnityEngine;

namespace ChestsGalore.Scripts.Modifications
{
    [EntityModification]
    public static class DoubleChestModifications
    {
        /* Glurch Chest */ [EntityModification(ObjectID.GlurchChest)]
        private static void EditGlurchChest(Entity entity, GameObject authoring, EntityManager entityManager)
        {
            // Get Behavior Data
            var chest = authoring.GetComponent<EntityMonoBehaviourData>();
            var inv = authoring.GetComponent<InventoryAuthoring>();
            if (chest is null || chest.objectInfo.variation != 0 || chest.objectInfo.requiredObjectsToCraft.Count > 1) return;
            if(inv is null || inv.itemsInInventory.Count > 0 || inv.addLootFromTable != LootTableID.Empty) return;
            // New Recipe
            var newList = new List<CraftingObject>{
                new() { objectID = ObjectID.SlimeBossSummoningItem, amount = 1 },
                new() { objectID = ObjectID.Slime, amount = 5 },
                new() { objectID = ObjectID.AncientGemstone, amount = 2 },
                new() { objectID = ObjectID.MechanicalPart, amount = 4 }
            };
            // Check and Set New Crafting Recipe and CanBeSalvaged Tag
            chest.objectInfo.requiredObjectsToCraft = newList;
            if(!chest.objectInfo.tags.Contains(ObjectCategoryTag.CanBeSalvaged))
                chest.objectInfo.tags.Add(ObjectCategoryTag.CanBeSalvaged);
        }
        /* King Slime Chest */ [EntityModification(ObjectID.KingSlimeChest)]
        private static void EditKingSlimeChest(Entity entity, GameObject authoring, EntityManager entityManager)
        {
            // Get Behavior Data
            var chest = authoring.GetComponent<EntityMonoBehaviourData>();
            var inv = authoring.GetComponent<InventoryAuthoring>();
            if (chest is null || chest.objectInfo.variation != 0 || chest.objectInfo.requiredObjectsToCraft.Count > 1) return;
            if(inv is null || inv.itemsInInventory.Count > 0 || inv.addLootFromTable != LootTableID.Empty) return;
            // New Recipe
            var newList = new List<CraftingObject>{
                new() { objectID = ObjectID.KingSlimeSummoningItem, amount = 1 },
                new() { objectID = ObjectID.Slime, amount = 10 },
                new() { objectID = ObjectID.AncientGemstone, amount = 2 },
                new() { objectID = ObjectID.MechanicalPart, amount = 4 }
            };
            // Check and Set New Crafting Recipe and CanBeSalvaged Tag
            chest.objectInfo.requiredObjectsToCraft = newList;
            if(!chest.objectInfo.tags.Contains(ObjectCategoryTag.CanBeSalvaged))
                chest.objectInfo.tags.Add(ObjectCategoryTag.CanBeSalvaged);
        }
        /* Ivy's Chest */ [EntityModification(ObjectID.IvyChest)]
        private static void EditIvyChest(Entity entity, GameObject authoring, EntityManager entityManager)
        {
            // Get Behavior Data
            var chest = authoring.GetComponent<EntityMonoBehaviourData>();
            var inv = authoring.GetComponent<InventoryAuthoring>();
            if (chest is null || chest.objectInfo.variation != 0 || chest.objectInfo.requiredObjectsToCraft.Count > 1) return;
            if(inv is null || inv.itemsInInventory.Count > 0 || inv.addLootFromTable != LootTableID.Empty) return;
            // New Recipe
            var newList = new List<CraftingObject>{
                new() { objectID = ObjectID.SlimeBossSummoningItem, amount = 1 },
                new() { objectID = ObjectID.PoisonSlime, amount = 5 },
                new() { objectID = ObjectID.AncientGemstone, amount = 2 },
                new() { objectID = ObjectID.MechanicalPart, amount = 4 }
            };
            // Check and Set New Crafting Recipe and CanBeSalvaged Tag
            chest.objectInfo.requiredObjectsToCraft = newList;
            if(!chest.objectInfo.tags.Contains(ObjectCategoryTag.CanBeSalvaged))
                chest.objectInfo.tags.Add(ObjectCategoryTag.CanBeSalvaged);
        }
        /* Morpha's Chest */ [EntityModification(ObjectID.MorphaChest)]
        private static void EditMorphaChest(Entity entity, GameObject authoring, EntityManager entityManager)
        {
            // Get Behavior Data
            var chest = authoring.GetComponent<EntityMonoBehaviourData>();
            var inv = authoring.GetComponent<InventoryAuthoring>();
            if (chest is null || chest.objectInfo.variation != 0 || chest.objectInfo.requiredObjectsToCraft.Count > 1) return;
            if(inv is null || inv.itemsInInventory.Count > 0 || inv.addLootFromTable != LootTableID.Empty) return;
            // New Recipe
            var newList = new List<CraftingObject>{
                new() { objectID = ObjectID.SlimeBossSummoningItem, amount = 1 },
                new() { objectID = ObjectID.SlipperySlime, amount = 5 },
                new() { objectID = ObjectID.AncientGemstone, amount = 2 },
                new() { objectID = ObjectID.MechanicalPart, amount = 4 }
            };
            // Check and Set New Crafting Recipe and CanBeSalvaged Tag
            chest.objectInfo.requiredObjectsToCraft = newList;
            if(!chest.objectInfo.tags.Contains(ObjectCategoryTag.CanBeSalvaged))
                chest.objectInfo.tags.Add(ObjectCategoryTag.CanBeSalvaged);
        }
        /* Igneous's Chest */ [EntityModification(ObjectID.LavaSlimeBossChest)]
        private static void EditIgneousChest(Entity entity, GameObject authoring, EntityManager entityManager)
        {
            // Get Behavior Data
            var chest = authoring.GetComponent<EntityMonoBehaviourData>();
            var inv = authoring.GetComponent<InventoryAuthoring>();
            if (chest is null || chest.objectInfo.variation != 0 || chest.objectInfo.requiredObjectsToCraft.Count > 1) return;
            if(inv is null || inv.itemsInInventory.Count > 0 || inv.addLootFromTable != LootTableID.Empty) return;
            // New Recipe
            var newList = new List<CraftingObject>{
                new() { objectID = ObjectID.SlimeBossSummoningItem, amount = 1 },
                new() { objectID = ObjectID.LavaSlime, amount = 5 },
                new() { objectID = ObjectID.AncientGemstone, amount = 2 },
                new() { objectID = ObjectID.MechanicalPart, amount = 4 }
            };
            // Check and Set New Crafting Recipe and CanBeSalvaged Tag
            chest.objectInfo.requiredObjectsToCraft = newList;
            if(!chest.objectInfo.tags.Contains(ObjectCategoryTag.CanBeSalvaged))
                chest.objectInfo.tags.Add(ObjectCategoryTag.CanBeSalvaged);
        }
        /* Urschleim's Chest */ [EntityModification(ObjectID.WallBossChest)]
        private static void EditUrschleimChest(Entity entity, GameObject authoring, EntityManager entityManager)
        {
            // Get Behavior Data
            var chest = authoring.GetComponent<EntityMonoBehaviourData>();
            var inv = authoring.GetComponent<InventoryAuthoring>();
            if (chest is null || chest.objectInfo.variation != 0 || chest.objectInfo.requiredObjectsToCraft.Count > 1) return;
            if(inv is null || inv.itemsInInventory.Count > 0 || inv.addLootFromTable != LootTableID.Empty) return;
            // New Recipe
            var newList = new List<CraftingObject>{
                new() { objectID = ObjectID.WallBossSummoningItem, amount = 1 },
                new() { objectID = ObjectID.Cytoplasm, amount = 5 },
                new() { objectID = ObjectID.AncientGemstone, amount = 2 },
                new() { objectID = ObjectID.MechanicalPart, amount = 4 }
            };
            // Check and Set New Crafting Recipe and CanBeSalvaged Tag
            chest.objectInfo.requiredObjectsToCraft = newList;
            if(!chest.objectInfo.tags.Contains(ObjectCategoryTag.CanBeSalvaged))
                chest.objectInfo.tags.Add(ObjectCategoryTag.CanBeSalvaged);
        }
        /* Ghorm's Chest */ [EntityModification(ObjectID.GhormChest)]
        private static void EditGhormChest(Entity entity, GameObject authoring, EntityManager entityManager)
        {
            // Get Behavior Data
            var chest = authoring.GetComponent<EntityMonoBehaviourData>();
            var inv = authoring.GetComponent<InventoryAuthoring>();
            if (chest is null || chest.objectInfo.variation != 0 || chest.objectInfo.requiredObjectsToCraft.Count > 1) return;
            if(inv is null || inv.itemsInInventory.Count > 0 || inv.addLootFromTable != LootTableID.Empty) return;
            // New Recipe
            var newList = new List<CraftingObject>{
                new() { objectID = ObjectID.LarvaBossSummoningItem, amount = 1 },
                new() { objectID = ObjectID.LarvaMeat, amount = 5 },
                new() { objectID = ObjectID.AncientGemstone, amount = 2 },
                new() { objectID = ObjectID.MechanicalPart, amount = 4 }
            };
            // Check and Set New Crafting Recipe and CanBeSalvaged Tag
            chest.objectInfo.requiredObjectsToCraft = newList;
            if(!chest.objectInfo.tags.Contains(ObjectCategoryTag.CanBeSalvaged))
                chest.objectInfo.tags.Add(ObjectCategoryTag.CanBeSalvaged);
        }
        /* Hive Mother's Chest */ [EntityModification(ObjectID.HivemotherChest)]
        private static void EditHiveMotherChest(Entity entity, GameObject authoring, EntityManager entityManager)
        {
            // Get Behavior Data
            var chest = authoring.GetComponent<EntityMonoBehaviourData>();
            var inv = authoring.GetComponent<InventoryAuthoring>();
            if (chest is null || chest.objectInfo.variation != 0 || chest.objectInfo.requiredObjectsToCraft.Count > 1) return;
            if(inv is null || inv.itemsInInventory.Count > 0 || inv.addLootFromTable != LootTableID.Empty) return;
            // New Recipe
            var newList = new List<CraftingObject>{
                new() { objectID = ObjectID.HiveBossSummoningItem, amount = 1 },
                new() { objectID = ObjectID.LarvaMeat, amount = 10 },
                new() { objectID = ObjectID.AncientGemstone, amount = 2 },
                new() { objectID = ObjectID.MechanicalPart, amount = 4 }
            };
            // Check and Set New Crafting Recipe and CanBeSalvaged Tag
            chest.objectInfo.requiredObjectsToCraft = newList;
            if(!chest.objectInfo.tags.Contains(ObjectCategoryTag.CanBeSalvaged))
                chest.objectInfo.tags.Add(ObjectCategoryTag.CanBeSalvaged);
        }
        /* Hive Mother's Halloween Chest */ [EntityModification(ObjectID.HivemotherHalloweenChest)]
        private static void EditHiveMotherHalloweenChest(Entity entity, GameObject authoring, EntityManager entityManager)
        {
            // Get Behavior Data
            var chest = authoring.GetComponent<EntityMonoBehaviourData>();
            var inv = authoring.GetComponent<InventoryAuthoring>();
            if (chest is null || chest.objectInfo.variation != 0 || chest.objectInfo.requiredObjectsToCraft.Count > 1) return;
            if(inv is null || inv.itemsInInventory.Count > 0 || inv.addLootFromTable != LootTableID.Empty) return;
            // New Recipe
            var newList = new List<CraftingObject>{
                new() { objectID = ObjectID.HiveHalloweenBossSummoningItem, amount = 1 },
                new() { objectID = ObjectID.LarvaMeat, amount = 10 },
                new() { objectID = ObjectID.AncientGemstone, amount = 2 },
                new() { objectID = ObjectID.MechanicalPart, amount = 4 }
            };
            // Check and Set New Crafting Recipe and CanBeSalvaged Tag
            chest.objectInfo.requiredObjectsToCraft = newList;
            if(!chest.objectInfo.tags.Contains(ObjectCategoryTag.CanBeSalvaged))
                chest.objectInfo.tags.Add(ObjectCategoryTag.CanBeSalvaged);
        }
        /* Titan's Chest */ [EntityModification(ObjectID.BossChest)]
        private static void EditTitanChest(Entity entity, GameObject authoring, EntityManager entityManager)
        {
            // Get Behavior Data
            var chest = authoring.GetComponent<EntityMonoBehaviourData>();
            var inv = authoring.GetComponent<InventoryAuthoring>();
            if (chest is null || chest.objectInfo.variation != 0 || chest.objectInfo.requiredObjectsToCraft.Count > 1) return;
            if(inv is null || inv.itemsInInventory.Count > 0 || inv.addLootFromTable != LootTableID.Empty) return;
            // New Recipe
            var newList = new List<CraftingObject>{
                new() { objectID = ObjectID.Thumper, amount = 1 },
                new() { objectID = ObjectID.AncientFeather, amount = 5 },
                new() { objectID = ObjectID.AncientGemstone, amount = 2 },
                new() { objectID = ObjectID.MechanicalPart, amount = 4 }
            };
            // Check and Set New Crafting Recipe and CanBeSalvaged Tag
            chest.objectInfo.requiredObjectsToCraft = newList;
            if(!chest.objectInfo.tags.Contains(ObjectCategoryTag.CanBeSalvaged))
                chest.objectInfo.tags.Add(ObjectCategoryTag.CanBeSalvaged);
        }
        /* Golden Titan's Chest */ [EntityModification(ObjectID.EasterChest)]
        private static void EditGoldenTitanChest(Entity entity, GameObject authoring, EntityManager entityManager)
        {
            // Get Behavior Data
            var chest = authoring.GetComponent<EntityMonoBehaviourData>();
            var inv = authoring.GetComponent<InventoryAuthoring>();
            if (chest is null || chest.objectInfo.variation != 0 || chest.objectInfo.requiredObjectsToCraft.Count > 1) return;
            if(inv is null || inv.itemsInInventory.Count > 0 || inv.addLootFromTable != LootTableID.Empty) return;
            // New Recipe
            var newList = new List<CraftingObject>{
                new() { objectID = ObjectID.EasterGoldenEgg, amount = 1 },
                new() { objectID = ObjectID.AncientFeather, amount = 5 },
                new() { objectID = ObjectID.AncientGemstone, amount = 2 },
                new() { objectID = ObjectID.MechanicalPart, amount = 4 }
            };
            // Check and Set New Crafting Recipe and CanBeSalvaged Tag
            chest.objectInfo.requiredObjectsToCraft = newList;
            if(!chest.objectInfo.tags.Contains(ObjectCategoryTag.CanBeSalvaged))
                chest.objectInfo.tags.Add(ObjectCategoryTag.CanBeSalvaged);
        }
        /* Floating Titan's Chest */ [EntityModification(ObjectID.OctopusBossChest)]
        private static void EditFloatingTitanChest(Entity entity, GameObject authoring, EntityManager entityManager)
        {
            // Get Behavior Data
            var chest = authoring.GetComponent<EntityMonoBehaviourData>();
            var inv = authoring.GetComponent<InventoryAuthoring>();
            if (chest is null || chest.objectInfo.variation != 0 || chest.objectInfo.requiredObjectsToCraft.Count > 1) return;
            if(inv is null || inv.itemsInInventory.Count > 0 || inv.addLootFromTable != LootTableID.Empty) return;
            // New Recipe
            var newList = new List<CraftingObject>{
                new() { objectID = ObjectID.BaitOctopusBoss, amount = 1 },
                new() { objectID = ObjectID.BaitIncreasedChanceToGetFishLoot, amount = 5 },
                new() { objectID = ObjectID.AncientGemstone, amount = 2 },
                new() { objectID = ObjectID.MechanicalPart, amount = 4 }
            };
            // Check and Set New Crafting Recipe and CanBeSalvaged Tag
            chest.objectInfo.requiredObjectsToCraft = newList;
            if(!chest.objectInfo.tags.Contains(ObjectCategoryTag.CanBeSalvaged))
                chest.objectInfo.tags.Add(ObjectCategoryTag.CanBeSalvaged);
        }
        /* Druidra's Chest */ [EntityModification(ObjectID.HydraBossNatureChest)]
        private static void EditDruidraChest(Entity entity, GameObject authoring, EntityManager entityManager)
        {
            // Get Behavior Data
            var chest = authoring.GetComponent<EntityMonoBehaviourData>();
            var inv = authoring.GetComponent<InventoryAuthoring>();
            if (chest is null || chest.objectInfo.variation != 0 || chest.objectInfo.requiredObjectsToCraft.Count > 1) return;
            if(inv is null || inv.itemsInInventory.Count > 0 || inv.addLootFromTable != LootTableID.Empty) return;
            // New Recipe
            var newList = new List<CraftingObject>{
                new() { objectID = ObjectID.HydraBossNatureBait, amount = 1 },
                new() { objectID = ObjectID.NatureGemstone, amount = 5 },
                new() { objectID = ObjectID.AncientGemstone, amount = 2 },
                new() { objectID = ObjectID.MechanicalPart, amount = 4 }
            };
            // Check and Set New Crafting Recipe and CanBeSalvaged Tag
            chest.objectInfo.requiredObjectsToCraft = newList;
            if(!chest.objectInfo.tags.Contains(ObjectCategoryTag.CanBeSalvaged))
                chest.objectInfo.tags.Add(ObjectCategoryTag.CanBeSalvaged);
        }
        /* Crydra's Chest */ [EntityModification(ObjectID.HydraBossSeaChest)]
        private static void EditCrydraChest(Entity entity, GameObject authoring, EntityManager entityManager)
        {
            // Get Behavior Data
            var chest = authoring.GetComponent<EntityMonoBehaviourData>();
            var inv = authoring.GetComponent<InventoryAuthoring>();
            if (chest is null || chest.objectInfo.variation != 0 || chest.objectInfo.requiredObjectsToCraft.Count > 1) return;
            if(inv is null || inv.itemsInInventory.Count > 0 || inv.addLootFromTable != LootTableID.Empty) return;
            // New Recipe
            var newList = new List<CraftingObject>{
                new() { objectID = ObjectID.HydraBossSeaBait, amount = 1 },
                new() { objectID = ObjectID.SeaGemstone, amount = 5 },
                new() { objectID = ObjectID.AncientGemstone, amount = 2 },
                new() { objectID = ObjectID.MechanicalPart, amount = 4 }
            };
            // Check and Set New Crafting Recipe and CanBeSalvaged Tag
            chest.objectInfo.requiredObjectsToCraft = newList;
            if(!chest.objectInfo.tags.Contains(ObjectCategoryTag.CanBeSalvaged))
                chest.objectInfo.tags.Add(ObjectCategoryTag.CanBeSalvaged);
        }
        /* Pyrdra's Chest */ [EntityModification(ObjectID.HydraBossDesertChest)]
        private static void EditPyrdraChest(Entity entity, GameObject authoring, EntityManager entityManager)
        {
            // Get Behavior Data
            var chest = authoring.GetComponent<EntityMonoBehaviourData>();
            var inv = authoring.GetComponent<InventoryAuthoring>();
            if (chest is null || chest.objectInfo.variation != 0 || chest.objectInfo.requiredObjectsToCraft.Count > 1) return;
            if(inv is null || inv.itemsInInventory.Count > 0 || inv.addLootFromTable != LootTableID.Empty) return;
            // New Recipe
            var newList = new List<CraftingObject>{
                new() { objectID = ObjectID.HydraBossDesertBait, amount = 1 },
                new() { objectID = ObjectID.DesertGemstone, amount = 5 },
                new() { objectID = ObjectID.AncientGemstone, amount = 2 },
                new() { objectID = ObjectID.MechanicalPart, amount = 4 }
            };
            // Check and Set New Crafting Recipe and CanBeSalvaged Tag
            chest.objectInfo.requiredObjectsToCraft = newList;
            if(!chest.objectInfo.tags.Contains(ObjectCategoryTag.CanBeSalvaged))
                chest.objectInfo.tags.Add(ObjectCategoryTag.CanBeSalvaged);
        }
        /* Malugaz's Chest */ [EntityModification(ObjectID.MalugazChest)]
        private static void EditMalugazChest(Entity entity, GameObject authoring, EntityManager entityManager)
        {
            // Get Behavior Data
            var chest = authoring.GetComponent<EntityMonoBehaviourData>();
            var inv = authoring.GetComponent<InventoryAuthoring>();
            if (chest is null || chest.objectInfo.variation != 0 || chest.objectInfo.requiredObjectsToCraft.Count > 1) return;
            if(inv is null || inv.itemsInInventory.Count > 0 || inv.addLootFromTable != LootTableID.Empty) return;
            // New Recipe
            var newList = new List<CraftingObject>{
                new() { objectID = ObjectID.ShamanBossSummoningItem, amount = 1 },
                new() { objectID = ObjectID.ShamanBossCrystalShard, amount = 5 },
                new() { objectID = ObjectID.AncientGemstone, amount = 2 },
                new() { objectID = ObjectID.MechanicalPart, amount = 4 }
            };
            // Check and Set New Crafting Recipe and CanBeSalvaged Tag
            chest.objectInfo.requiredObjectsToCraft = newList;
            if(!chest.objectInfo.tags.Contains(ObjectCategoryTag.CanBeSalvaged))
                chest.objectInfo.tags.Add(ObjectCategoryTag.CanBeSalvaged);
        }
        /* Atlantian Worm's Chest */ [EntityModification(ObjectID.AtlantianWormChest)]
        private static void EditAtlantianWormChest(Entity entity, GameObject authoring, EntityManager entityManager)
        {
            // Get Behavior Data
            var chest = authoring.GetComponent<EntityMonoBehaviourData>();
            var inv = authoring.GetComponent<InventoryAuthoring>();
            if (chest is null || chest.objectInfo.variation != 0 || chest.objectInfo.requiredObjectsToCraft.Count > 1) return;
            if(inv is null || inv.itemsInInventory.Count > 0 || inv.addLootFromTable != LootTableID.Empty) return;
            // New Recipe
            var newList = new List<CraftingObject>{
                new() { objectID = ObjectID.BaitOnAPole, amount = 1 },
                new() { objectID = ObjectID.CookedSushi, amount = 5 },
                new() { objectID = ObjectID.AncientGemstone, amount = 2 },
                new() { objectID = ObjectID.MechanicalPart, amount = 4 }
            };
            // Check and Set New Crafting Recipe and CanBeSalvaged Tag
            chest.objectInfo.requiredObjectsToCraft = newList;
            if(!chest.objectInfo.tags.Contains(ObjectCategoryTag.CanBeSalvaged))
                chest.objectInfo.tags.Add(ObjectCategoryTag.CanBeSalvaged);
        }
        /* Colossal Cicada's Chest */ [EntityModification(ObjectID.GiantCicadaChest)]
        private static void EditGiantCicadaChest(Entity entity, GameObject authoring, EntityManager entityManager)
        {
            // Get Behavior Data
            var chest = authoring.GetComponent<EntityMonoBehaviourData>();
            var inv = authoring.GetComponent<InventoryAuthoring>();
            if (chest is null || chest.objectInfo.variation != 0 || chest.objectInfo.requiredObjectsToCraft.Count > 1) return;
            if(inv is null || inv.itemsInInventory.Count > 0 || inv.addLootFromTable != LootTableID.Empty) return;
            // New Recipe
            var newList = new List<CraftingObject>{
                new() { objectID = ObjectID.GiantCicadaBossSummoningItem, amount = 1 },
                new() { objectID = ObjectID.BlastingDung, amount = 10 },
                new() { objectID = ObjectID.AncientGemstone, amount = 2 },
                new() { objectID = ObjectID.MechanicalPart, amount = 4 }
            };
            // Check and Set New Crafting Recipe and CanBeSalvaged Tag
            chest.objectInfo.requiredObjectsToCraft = newList;
            if(!chest.objectInfo.tags.Contains(ObjectCategoryTag.CanBeSalvaged))
                chest.objectInfo.tags.Add(ObjectCategoryTag.CanBeSalvaged);
        }
        /* Core Commander's Chest */ [EntityModification(ObjectID.CoreCommanderChest)]
        private static void EditCoreCommanderChest(Entity entity, GameObject authoring, EntityManager entityManager)
        {
            // Get Behavior Data
            var chest = authoring.GetComponent<EntityMonoBehaviourData>();
            var inv = authoring.GetComponent<InventoryAuthoring>();
            if (chest is null || chest.objectInfo.variation != 0 || chest.objectInfo.requiredObjectsToCraft.Count > 1) return;
            if(inv is null || inv.itemsInInventory.Count > 0 || inv.addLootFromTable != LootTableID.Empty) return;
            // New Recipe
            var newList = new List<CraftingObject>{
                new() { objectID = ObjectID.CoreBossSummoningItem, amount = 1 },
                new() { objectID = ObjectID.PandoriumBar, amount = 10 },
                new() { objectID = ObjectID.AncientGemstone, amount = 2 },
                new() { objectID = ObjectID.MechanicalPart, amount = 4 }
            };
            // Check and Set New Crafting Recipe and CanBeSalvaged Tag
            chest.objectInfo.requiredObjectsToCraft = newList;
            if(!chest.objectInfo.tags.Contains(ObjectCategoryTag.CanBeSalvaged))
                chest.objectInfo.tags.Add(ObjectCategoryTag.CanBeSalvaged);
        }
    }
}