using System.Collections.Generic;
using CoreLib.Submodule.Entity.Attribute;
using Unity.Entities;
using UnityEngine;

namespace ChestsGalore.Scripts.Modifications
{
    public static class DoubleChestModifications
    {
        /* Glurch Chest */ [EntityModification(ObjectID.GlurchChest)]
        private static void EditGlurchChest(Entity entity, GameObject authoring, EntityManager entityManager)
        {
            // Check if valid Chest and set Salvage
            if(!ChestModifications.IsValidChest(authoring, out var chest)) return;
            ChestModifications.SetCanBeSalvaged(chest);
            
            // New Recipe
            chest.objectInfo.requiredObjectsToCraft = new List<CraftingObject>{
                new() { objectID = ObjectID.SlimeBossSummoningItem, amount = 1 },
                new() { objectID = ObjectID.Slime, amount = 5 },
                new() { objectID = ObjectID.AncientGemstone, amount = 2 },
                new() { objectID = ObjectID.MechanicalPart, amount = 4 }
            };
        }
        /* King Slime Chest */ [EntityModification(ObjectID.KingSlimeChest)]
        private static void EditKingSlimeChest(Entity entity, GameObject authoring, EntityManager entityManager)
        {
            // Check if valid Chest and set Salvage
            if(!ChestModifications.IsValidChest(authoring, out var chest)) return;
            ChestModifications.SetCanBeSalvaged(chest);
            
            // New Recipe
            chest.objectInfo.requiredObjectsToCraft = new List<CraftingObject>{
                new() { objectID = ObjectID.KingSlimeSummoningItem, amount = 1 },
                new() { objectID = ObjectID.Slime, amount = 10 },
                new() { objectID = ObjectID.AncientGemstone, amount = 2 },
                new() { objectID = ObjectID.MechanicalPart, amount = 4 }
            };
        }
        /* Ivy's Chest */ [EntityModification(ObjectID.IvyChest)]
        private static void EditIvyChest(Entity entity, GameObject authoring, EntityManager entityManager)
        {
            // Check if valid Chest and set Salvage
            if(!ChestModifications.IsValidChest(authoring, out var chest)) return;
            ChestModifications.SetCanBeSalvaged(chest);
            
            // New Recipe
            chest.objectInfo.requiredObjectsToCraft = new List<CraftingObject>{
                new() { objectID = ObjectID.SlimeBossSummoningItem, amount = 1 },
                new() { objectID = ObjectID.PoisonSlime, amount = 5 },
                new() { objectID = ObjectID.AncientGemstone, amount = 2 },
                new() { objectID = ObjectID.MechanicalPart, amount = 4 }
            };
        }
        /* Morpha's Chest */ [EntityModification(ObjectID.MorphaChest)]
        private static void EditMorphaChest(Entity entity, GameObject authoring, EntityManager entityManager)
        {
            // Check if valid Chest and set Salvage
            if(!ChestModifications.IsValidChest(authoring, out var chest)) return;
            ChestModifications.SetCanBeSalvaged(chest);
            
            // New Recipe
            chest.objectInfo.requiredObjectsToCraft = new List<CraftingObject>{
                new() { objectID = ObjectID.SlimeBossSummoningItem, amount = 1 },
                new() { objectID = ObjectID.SlipperySlime, amount = 5 },
                new() { objectID = ObjectID.AncientGemstone, amount = 2 },
                new() { objectID = ObjectID.MechanicalPart, amount = 4 }
            };
        }
        /* Igneous's Chest */ [EntityModification(ObjectID.LavaSlimeBossChest)]
        private static void EditIgneousChest(Entity entity, GameObject authoring, EntityManager entityManager)
        {
            // Check if valid Chest and set Salvage
            if(!ChestModifications.IsValidChest(authoring, out var chest)) return;
            ChestModifications.SetCanBeSalvaged(chest);
            
            // New Recipe
            chest.objectInfo.requiredObjectsToCraft = new List<CraftingObject>{
                new() { objectID = ObjectID.SlimeBossSummoningItem, amount = 1 },
                new() { objectID = ObjectID.LavaSlime, amount = 5 },
                new() { objectID = ObjectID.AncientGemstone, amount = 2 },
                new() { objectID = ObjectID.MechanicalPart, amount = 4 }
            };
        }
        /* Urschleim's Chest */ [EntityModification(ObjectID.WallBossChest)]
        private static void EditUrschleimChest(Entity entity, GameObject authoring, EntityManager entityManager)
        {
            // Check if valid Chest and set Salvage
            if(!ChestModifications.IsValidChest(authoring, out var chest)) return;
            ChestModifications.SetCanBeSalvaged(chest);
            
            // New Recipe
            chest.objectInfo.requiredObjectsToCraft = new List<CraftingObject>{
                new() { objectID = ObjectID.WallBossSummoningItem, amount = 1 },
                new() { objectID = ObjectID.Cytoplasm, amount = 5 },
                new() { objectID = ObjectID.AncientGemstone, amount = 2 },
                new() { objectID = ObjectID.MechanicalPart, amount = 4 }
            };
        }
        /* Ghorm's Chest */ [EntityModification(ObjectID.GhormChest)]
        private static void EditGhormChest(Entity entity, GameObject authoring, EntityManager entityManager)
        {
            // Check if valid Chest and set Salvage
            if(!ChestModifications.IsValidChest(authoring, out var chest)) return;
            ChestModifications.SetCanBeSalvaged(chest);
            
            // New Recipe
            chest.objectInfo.requiredObjectsToCraft = new List<CraftingObject>{
                new() { objectID = ObjectID.LarvaBossSummoningItem, amount = 1 },
                new() { objectID = ObjectID.LarvaMeat, amount = 5 },
                new() { objectID = ObjectID.AncientGemstone, amount = 2 },
                new() { objectID = ObjectID.MechanicalPart, amount = 4 }
            };
        }
        /* Hive Mother's Chest */ [EntityModification(ObjectID.HivemotherChest)]
        private static void EditHiveMotherChest(Entity entity, GameObject authoring, EntityManager entityManager)
        {
            // Check if valid Chest and set Salvage
            if(!ChestModifications.IsValidChest(authoring, out var chest)) return;
            ChestModifications.SetCanBeSalvaged(chest);
            
            // New Recipe
            chest.objectInfo.requiredObjectsToCraft = new List<CraftingObject>{
                new() { objectID = ObjectID.HiveBossSummoningItem, amount = 1 },
                new() { objectID = ObjectID.LarvaMeat, amount = 10 },
                new() { objectID = ObjectID.AncientGemstone, amount = 2 },
                new() { objectID = ObjectID.MechanicalPart, amount = 4 }
            };
        }
        /* Hive Mother's Halloween Chest */ [EntityModification(ObjectID.HivemotherHalloweenChest)]
        private static void EditHiveMotherHalloweenChest(Entity entity, GameObject authoring, EntityManager entityManager)
        {
            // Check if valid Chest and set Salvage
            if(!ChestModifications.IsValidChest(authoring, out var chest)) return;
            ChestModifications.SetCanBeSalvaged(chest);
            
            // New Recipe
            chest.objectInfo.requiredObjectsToCraft = new List<CraftingObject>{
                new() { objectID = ObjectID.HiveHalloweenBossSummoningItem, amount = 1 },
                new() { objectID = ObjectID.LarvaMeat, amount = 10 },
                new() { objectID = ObjectID.AncientGemstone, amount = 2 },
                new() { objectID = ObjectID.MechanicalPart, amount = 4 }
            };
        }
        /* Titan's Chest */ [EntityModification(ObjectID.BossChest)]
        private static void EditTitanChest(Entity entity, GameObject authoring, EntityManager entityManager)
        {
            // Check if valid Chest and set Salvage
            if(!ChestModifications.IsValidChest(authoring, out var chest)) return;
            ChestModifications.SetCanBeSalvaged(chest);
            
            // New Recipe
            chest.objectInfo.requiredObjectsToCraft = new List<CraftingObject>{
                new() { objectID = ObjectID.Thumper, amount = 1 },
                new() { objectID = ObjectID.AncientFeather, amount = 5 },
                new() { objectID = ObjectID.AncientGemstone, amount = 2 },
                new() { objectID = ObjectID.MechanicalPart, amount = 4 }
            };
        }
        /* Golden Titan's Chest */ [EntityModification(ObjectID.EasterChest)]
        private static void EditGoldenTitanChest(Entity entity, GameObject authoring, EntityManager entityManager)
        {
            // Check if valid Chest and set Salvage
            if(!ChestModifications.IsValidChest(authoring, out var chest)) return;
            ChestModifications.SetCanBeSalvaged(chest);
            
            // New Recipe
            chest.objectInfo.requiredObjectsToCraft = new List<CraftingObject>{
                new() { objectID = ObjectID.EasterGoldenEgg, amount = 1 },
                new() { objectID = ObjectID.AncientFeather, amount = 5 },
                new() { objectID = ObjectID.AncientGemstone, amount = 2 },
                new() { objectID = ObjectID.MechanicalPart, amount = 4 }
            };
        }
        /* Floating Titan's Chest */ [EntityModification(ObjectID.OctopusBossChest)]
        private static void EditFloatingTitanChest(Entity entity, GameObject authoring, EntityManager entityManager)
        {
            // Check if valid Chest and set Salvage
            if(!ChestModifications.IsValidChest(authoring, out var chest)) return;
            ChestModifications.SetCanBeSalvaged(chest);
            
            // New Recipe
            chest.objectInfo.requiredObjectsToCraft = new List<CraftingObject>{
                new() { objectID = ObjectID.BaitOctopusBoss, amount = 1 },
                new() { objectID = ObjectID.BaitIncreasedChanceToGetFishLoot, amount = 5 },
                new() { objectID = ObjectID.AncientGemstone, amount = 2 },
                new() { objectID = ObjectID.MechanicalPart, amount = 4 }
            };
        }
        /* Druidra's Chest */ [EntityModification(ObjectID.HydraBossNatureChest)]
        private static void EditDruidraChest(Entity entity, GameObject authoring, EntityManager entityManager)
        {
            // Check if valid Chest and set Salvage
            if(!ChestModifications.IsValidChest(authoring, out var chest)) return;
            ChestModifications.SetCanBeSalvaged(chest);
            
            // New Recipe
            chest.objectInfo.requiredObjectsToCraft = new List<CraftingObject>{
                new() { objectID = ObjectID.HydraBossNatureBait, amount = 1 },
                new() { objectID = ObjectID.NatureGemstone, amount = 5 },
                new() { objectID = ObjectID.AncientGemstone, amount = 2 },
                new() { objectID = ObjectID.MechanicalPart, amount = 4 }
            };
        }
        /* Crydra's Chest */ [EntityModification(ObjectID.HydraBossSeaChest)]
        private static void EditCrydraChest(Entity entity, GameObject authoring, EntityManager entityManager)
        {
            // Check if valid Chest and set Salvage
            if(!ChestModifications.IsValidChest(authoring, out var chest)) return;
            ChestModifications.SetCanBeSalvaged(chest);
            
            // New Recipe
            chest.objectInfo.requiredObjectsToCraft = new List<CraftingObject>{
                new() { objectID = ObjectID.HydraBossSeaBait, amount = 1 },
                new() { objectID = ObjectID.SeaGemstone, amount = 5 },
                new() { objectID = ObjectID.AncientGemstone, amount = 2 },
                new() { objectID = ObjectID.MechanicalPart, amount = 4 }
            };
        }
        /* Pyrdra's Chest */ [EntityModification(ObjectID.HydraBossDesertChest)]
        private static void EditPyrdraChest(Entity entity, GameObject authoring, EntityManager entityManager)
        {
            // Check if valid Chest and set Salvage
            if(!ChestModifications.IsValidChest(authoring, out var chest)) return;
            ChestModifications.SetCanBeSalvaged(chest);
            
            // New Recipe
            chest.objectInfo.requiredObjectsToCraft = new List<CraftingObject>{
                new() { objectID = ObjectID.HydraBossDesertBait, amount = 1 },
                new() { objectID = ObjectID.DesertGemstone, amount = 5 },
                new() { objectID = ObjectID.AncientGemstone, amount = 2 },
                new() { objectID = ObjectID.MechanicalPart, amount = 4 }
            };
        }
        /* Oblidra's Chest */ [EntityModification(ObjectID.HydraBossVoidChest)]
        private static void EditOblidraChest(Entity entity, GameObject authoring, EntityManager entityManager)
        {
            // Check if valid Chest and set Salvage
            if(!ChestModifications.IsValidChest(authoring, out var chest)) return;
            ChestModifications.SetCanBeSalvaged(chest);
            
            // New Recipe
            chest.objectInfo.requiredObjectsToCraft = new List<CraftingObject>{
                new() { objectID = ObjectID.HydraBossVoidBait, amount = 1 },
                new() { objectID = ObjectID.CorruptedAlloy, amount = 5 },
                new() { objectID = ObjectID.AncientGemstone, amount = 2 },
                new() { objectID = ObjectID.MechanicalPart, amount = 4 }
            };
        }
        /* Malugaz's Chest */ [EntityModification(ObjectID.MalugazChest)]
        private static void EditMalugazChest(Entity entity, GameObject authoring, EntityManager entityManager)
        {
            // Check if valid Chest and set Salvage
            if(!ChestModifications.IsValidChest(authoring, out var chest)) return;
            ChestModifications.SetCanBeSalvaged(chest);
            
            // New Recipe
            chest.objectInfo.requiredObjectsToCraft = new List<CraftingObject>{
                new() { objectID = ObjectID.ShamanBossSummoningItem, amount = 1 },
                new() { objectID = ObjectID.ShamanBossCrystalShard, amount = 5 },
                new() { objectID = ObjectID.AncientGemstone, amount = 2 },
                new() { objectID = ObjectID.MechanicalPart, amount = 4 }
            };
        }
        /* Atlantian Worm's Chest */ [EntityModification(ObjectID.AtlantianWormChest)]
        private static void EditAtlantianWormChest(Entity entity, GameObject authoring, EntityManager entityManager)
        {
            // Check if valid Chest and set Salvage
            if(!ChestModifications.IsValidChest(authoring, out var chest)) return;
            ChestModifications.SetCanBeSalvaged(chest);
            
            // New Recipe
            chest.objectInfo.requiredObjectsToCraft = new List<CraftingObject>{
                new() { objectID = ObjectID.BaitOnAPole, amount = 1 },
                new() { objectID = ObjectID.CookedSushi, amount = 5 },
                new() { objectID = ObjectID.AncientGemstone, amount = 2 },
                new() { objectID = ObjectID.MechanicalPart, amount = 4 }
            };
        }
        /* Colossal Cicada's Chest */ [EntityModification(ObjectID.GiantCicadaChest)]
        private static void EditGiantCicadaChest(Entity entity, GameObject authoring, EntityManager entityManager)
        {
            // Check if valid Chest and set Salvage
            if(!ChestModifications.IsValidChest(authoring, out var chest)) return;
            ChestModifications.SetCanBeSalvaged(chest);
            
            // New Recipe
            chest.objectInfo.requiredObjectsToCraft = new List<CraftingObject>{
                new() { objectID = ObjectID.GiantCicadaBossSummoningItem, amount = 1 },
                new() { objectID = ObjectID.BlastingDung, amount = 10 },
                new() { objectID = ObjectID.AncientGemstone, amount = 2 },
                new() { objectID = ObjectID.MechanicalPart, amount = 4 }
            };
        }
        /* Core Commander's Chest */ [EntityModification(ObjectID.CoreCommanderChest)]
        private static void EditCoreCommanderChest(Entity entity, GameObject authoring, EntityManager entityManager)
        {
            // Check if valid Chest and set Salvage
            if(!ChestModifications.IsValidChest(authoring, out var chest)) return;
            ChestModifications.SetCanBeSalvaged(chest);
            
            // New Recipe
            chest.objectInfo.requiredObjectsToCraft = new List<CraftingObject>{
                new() { objectID = ObjectID.CoreBossSummoningItem, amount = 1 },
                new() { objectID = ObjectID.PandoriumBar, amount = 10 },
                new() { objectID = ObjectID.AncientGemstone, amount = 2 },
                new() { objectID = ObjectID.MechanicalPart, amount = 4 }
            };
        }
        /* S.A.H.A.B.A.R.'s Chest */ [EntityModification(ObjectID.RobotBossChest)]
        private static void EditSahabarChest(Entity entity, GameObject authoring, EntityManager entityManager)
        {
            // Check if valid Chest and set Salvage
            if(!ChestModifications.IsValidChest(authoring, out var chest)) return;
            ChestModifications.SetCanBeSalvaged(chest);
            Debug.Log("Sahabar Chest");
            
            // New Recipe
            chest.objectInfo.requiredObjectsToCraft = new List<CraftingObject>{
                new() { objectID = ObjectID.RobotBossSummoningItem, amount = 1 },
                new() { objectID = ObjectID.ReluciteBar, amount = 10 },
                new() { objectID = ObjectID.AncientGemstone, amount = 2 },
                new() { objectID = ObjectID.MechanicalPart, amount = 4 }
            };
        }
    }
}