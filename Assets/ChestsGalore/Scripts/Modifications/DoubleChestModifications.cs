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
        /* Urschleim's Chest Modifications:
         - Change Recipe:
            - 1 Primeval Slime Cell
            - 5 Cytoplasm
            - 2 Ancient Gemstone
            - 4 Mechanical Part
         - Make Chest Salvageable
         */
        [EntityModification(ObjectID.WallBossChest)]
        private static void EditUrschleimChest(Entity entity, GameObject authoring, EntityManager entityManager)
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
                    objectID = ObjectID.WallBossSummoningItem,
                    amount = 1
                },
                new CraftingObject
                {
                    objectID = ObjectID.Cytoplasm,
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
        /* Ghorm's Chest Modifications:
         - Change Recipe:
            - 1 Ghorm Summoning Idol
            - 5 Larva Meat
            - 2 Ancient Gemstone
            - 4 Mechanical Part
         - Make Chest Salvageable
         */
        [EntityModification(ObjectID.GhormChest)]
        private static void EditGhormChest(Entity entity, GameObject authoring, EntityManager entityManager)
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
                    objectID = ObjectID.LarvaBossSummoningItem,
                    amount = 1
                },
                new CraftingObject
                {
                    objectID = ObjectID.LarvaMeat,
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
        /* Hive Mother's Chest Modifications:
         - Change Recipe:
            - 1 Hive Mother Summoning Idol
            - 10 Larva Meat
            - 2 Ancient Gemstone
            - 4 Mechanical Part
         - Make Chest Salvageable
         */
        [EntityModification(ObjectID.HivemotherChest)]
        private static void EditHiveMotherChest(Entity entity, GameObject authoring, EntityManager entityManager)
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
                    objectID = ObjectID.HiveBossSummoningItem,
                    amount = 1
                },
                new CraftingObject
                {
                    objectID = ObjectID.LarvaMeat,
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
        /* Hive Mother's Halloween Chest Modifications:
         - Change Recipe:
            - 1 Haunted Hive Mother Summoning Idol
            - 10 Larva Meat
            - 2 Ancient Gemstone
            - 4 Mechanical Part
         - Make Chest Salvageable
         */
        [EntityModification(ObjectID.HivemotherHalloweenChest)]
        private static void EditHiveMotherHalloweenChest(Entity entity, GameObject authoring, EntityManager entityManager)
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
                    objectID = ObjectID.HiveHalloweenBossSummoningItem,
                    amount = 1
                },
                new CraftingObject
                {
                    objectID = ObjectID.LarvaMeat,
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
        /* Titan's Chest Modifications:
        - Change Recipe:
           - 1 Thumper
           - 5 Ancient Feather
           - 2 Ancient Gemstone
           - 4 Mechanical Part
        - Make Chest Salvageable
        */
        [EntityModification(ObjectID.BossChest)]
        private static void EditTitanChest(Entity entity, GameObject authoring, EntityManager entityManager)
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
                    objectID = ObjectID.Thumper,
                    amount = 1
                },
                new CraftingObject
                {
                    objectID = ObjectID.AncientFeather,
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
        /* Golden Titan's Chest Modifications:
        - Change Recipe:
           - 1 Large Golden Egg
           - 5 Ancient Feather
           - 2 Ancient Gemstone
           - 4 Mechanical Part
        - Make Chest Salvageable
        */
        [EntityModification(ObjectID.EasterChest)]
        private static void EditGoldenTitanChest(Entity entity, GameObject authoring, EntityManager entityManager)
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
                    objectID = ObjectID.EasterGoldenEgg,
                    amount = 1
                },
                new CraftingObject
                {
                    objectID = ObjectID.AncientFeather,
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
        /* Floating Titan's Chest Modifications:
        - Change Recipe:
           - 1 Expert Lure
           - 5 Glowing Bait
           - 2 Ancient Gemstone
           - 4 Mechanical Part
        - Make Chest Salvageable
        */
        [EntityModification(ObjectID.OctopusBossChest)]
        private static void EditFloatingTitanChest(Entity entity, GameObject authoring, EntityManager entityManager)
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
                    objectID = ObjectID.BaitOctopusBoss,
                    amount = 1
                },
                new CraftingObject
                {
                    objectID = ObjectID.BaitIncreasedChanceToGetFishLoot,
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
        /* Druidra's Chest Modifications:
        - Change Recipe:
           - 1 Wind Organ of Wilderness
           - 5 Jungle Emerald
           - 2 Ancient Gemstone
           - 4 Mechanical Part
        - Make Chest Salvageable
        */
        [EntityModification(ObjectID.HydraBossNatureChest)]
        private static void EditDruidraChest(Entity entity, GameObject authoring, EntityManager entityManager)
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
                    objectID = ObjectID.HydraBossNatureBait,
                    amount = 1
                },
                new CraftingObject
                {
                    objectID = ObjectID.NatureGemstone,
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
        /* Crydra's Chest Modifications:
        - Change Recipe:
           - 1 Wind Organ of Ice
           - 5 Ocean Sapphire
           - 2 Ancient Gemstone
           - 4 Mechanical Part
        - Make Chest Salvageable
        */
        [EntityModification(ObjectID.HydraBossSeaChest)]
        private static void EditCrydraChest(Entity entity, GameObject authoring, EntityManager entityManager)
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
                    objectID = ObjectID.HydraBossSeaBait,
                    amount = 1
                },
                new CraftingObject
                {
                    objectID = ObjectID.SeaGemstone,
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
        /* Pyrdra's Chest Modifications:
        - Change Recipe:
           - 1 Wind Organ of Fire
           - 5 Desert Ruby
           - 2 Ancient Gemstone
           - 4 Mechanical Part
        - Make Chest Salvageable
        */
        [EntityModification(ObjectID.HydraBossDesertChest)]
        private static void EditPyrdraChest(Entity entity, GameObject authoring, EntityManager entityManager)
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
                    objectID = ObjectID.HydraBossDesertBait,
                    amount = 1
                },
                new CraftingObject
                {
                    objectID = ObjectID.DesertGemstone,
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
        /* Malugaz's Chest Modifications:
        - Change Recipe:
           - 1 Malugaz Summoning Idol
           - 5 Crystal Skull Shard
           - 2 Ancient Gemstone
           - 4 Mechanical Part
        - Make Chest Salvageable
        */
        [EntityModification(ObjectID.MalugazChest)]
        private static void EditMalugazChest(Entity entity, GameObject authoring, EntityManager entityManager)
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
                    objectID = ObjectID.ShamanBossSummoningItem,
                    amount = 1
                },
                new CraftingObject
                {
                    objectID = ObjectID.ShamanBossCrystalShard,
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
        /* Atlantian Worm's Chest Modifications:
        - Change Recipe:
           - 1 Bait Pillar
           - 5 Cooked Sushi
           - 2 Ancient Gemstone
           - 4 Mechanical Part
        - Make Chest Salvageable
        */
        [EntityModification(ObjectID.AtlantianWormChest)]
        private static void EditAtlantianWormChest(Entity entity, GameObject authoring, EntityManager entityManager)
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
                    objectID = ObjectID.BaitOnAPole,
                    amount = 1
                },
                new CraftingObject
                {
                    objectID = ObjectID.CookedSushi,
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
        /* Colossal Cicada's Chest Modifications:
         - Change Recipe:
            - 1 Corrupted Sap
            - 10 Blasting Dung
            - 2 Ancient Gemstone
            - 4 Mechanical Part
         - Make Chest Salvageable
         */
        [EntityModification(ObjectID.GiantCicadaChest)]
        private static void EditGiantCicadaChest(Entity entity, GameObject authoring, EntityManager entityManager)
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
                    objectID = ObjectID.GiantCicadaBossSummoningItem,
                    amount = 1
                },
                new CraftingObject
                {
                    objectID = ObjectID.BlastingDung,
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
        /* Core Commander's Chest Modifications:
        - Change Recipe:
           - 1 Core Commander Summoning Idol
           - 10 Pandorium Bar
           - 2 Ancient Gemstone
           - 4 Mechanical Part
        - Make Chest Salvageable
        */
        [EntityModification(ObjectID.CoreCommanderChest)]
        private static void EditCoreCommanderChest(Entity entity, GameObject authoring, EntityManager entityManager)
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
                    objectID = ObjectID.CoreBossSummoningItem,
                    amount = 1
                },
                new CraftingObject
                {
                    objectID = ObjectID.PandoriumBar,
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
    }
}