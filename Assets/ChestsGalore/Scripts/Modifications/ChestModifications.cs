using System.Collections.Generic;
using CoreLib.Submodules.ModEntity.Atributes;
using Unity.Entities;
using UnityEngine;

// ReSharper disable once CheckNamespace
namespace ChestsGalore.Scripts.Modifications
{
    [EntityModification]
    public static class ChestModifications
    {
        /* Chest Modifications:
         - Make Chest Salvageable
         */
        [EntityModification(ObjectID.InventoryChest)]
        private static void EditChest(Entity entity, GameObject authoring, EntityManager entityManager)
        {
            // Get Behavior Data
            EntityMonoBehaviourData chest = authoring.GetComponent<EntityMonoBehaviourData>();
            InventoryAuthoring inv = authoring.GetComponent<InventoryAuthoring>();
            if (chest is null || chest.objectInfo.variation != 0 || chest.objectInfo.requiredObjectsToCraft.Count > 1) return;
            if(inv is null || inv.itemsInInventory.Count > 0 || inv.addLootFromTable != LootTableID.Empty) return;
            
            // Check and Set CanBeSalvaged Tag
            if(!chest.objectInfo.tags.Contains(ObjectCategoryTag.CanBeSalvaged))
                chest.objectInfo.tags.Add(ObjectCategoryTag.CanBeSalvaged);
        }
        /* Copper Chest Modifications:
         - Change Recipe:
            - 5 Copper Bars
            - 5 Wood
         - Make Chest Salvageable
         */
        [EntityModification(ObjectID.CopperChest)]
        private static void EditCopperChest(Entity entity, GameObject authoring, EntityManager entityManager)
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
                    objectID = ObjectID.CopperBar,
                    amount = 5
                },
                new CraftingObject
                {
                    objectID = ObjectID.Wood,
                    amount = 5
                }
            };
            
            // Check and Set New Crafting Recipe and CanBeSalvaged Tag
            chest.objectInfo.requiredObjectsToCraft = newList;

            if(!chest.objectInfo.tags.Contains(ObjectCategoryTag.CanBeSalvaged))
                chest.objectInfo.tags.Add(ObjectCategoryTag.CanBeSalvaged);
        }
        /* Iron Chest Modifications:
         - Change Recipe:
            - 5 Iron Bars
            - 5 Wood
         - Make Chest Salvageable
         */
        [EntityModification(ObjectID.IronChest)]
        private static void EditIronChest(Entity entity, GameObject authoring, EntityManager entityManager)
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
                    objectID = ObjectID.IronBar,
                    amount = 5
                },
                new CraftingObject
                {
                    objectID = ObjectID.Wood,
                    amount = 5
                }
            };

            // Check and Set New Crafting Recipe and CanBeSalvaged Tag
            chest.objectInfo.requiredObjectsToCraft = newList;

            if(!chest.objectInfo.tags.Contains(ObjectCategoryTag.CanBeSalvaged))
                chest.objectInfo.tags.Add(ObjectCategoryTag.CanBeSalvaged);

        }
        /* Scarlet Chest Modifications:
         - Change Recipe:
            - 5 Scarlet Bars
            - 5 Wood
         - Make Chest Salvageable
         */
        [EntityModification(ObjectID.ScarletChest)]
        private static void EditScarletChest(Entity entity, GameObject authoring, EntityManager entityManager)
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
                    objectID = ObjectID.ScarletBar,
                    amount = 5
                },
                new CraftingObject
                {
                    objectID = ObjectID.Wood,
                    amount = 5
                }
            };

            // Check and Set New Crafting Recipe and CanBeSalvaged Tag
            chest.objectInfo.requiredObjectsToCraft = newList;

            if(!chest.objectInfo.tags.Contains(ObjectCategoryTag.CanBeSalvaged))
                chest.objectInfo.tags.Add(ObjectCategoryTag.CanBeSalvaged);

        }
        /* Octarine Chest Modifications:
         - Change Recipe:
            - 5 Octarine Bars
            - 5 Coral Wood
         - Make Chest Salvageable
         */
        [EntityModification(ObjectID.OctarineChest)]
        private static void EditOctarineChest(Entity entity, GameObject authoring, EntityManager entityManager)
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
                    objectID = ObjectID.OctarineBar,
                    amount = 5
                },
                new CraftingObject
                {
                    objectID = ObjectID.CoralWood,
                    amount = 5
                }
            };

            // Check and Set New Crafting Recipe and CanBeSalvaged Tag
            chest.objectInfo.requiredObjectsToCraft = newList;

            if(!chest.objectInfo.tags.Contains(ObjectCategoryTag.CanBeSalvaged))
                chest.objectInfo.tags.Add(ObjectCategoryTag.CanBeSalvaged);
        }
        /* Galaxite Chest Modifications:
         - Change Recipe:
            - 5 Galaxite Bars
            - 5 Coral Wood
         - Make Chest Salvageable
         */
        [EntityModification(ObjectID.GalaxiteChest)]
        private static void EditGalaxiteChest(Entity entity, GameObject authoring, EntityManager entityManager)
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
                    objectID = ObjectID.GalaxiteBar,
                    amount = 5
                },
                new CraftingObject
                {
                    objectID = ObjectID.CoralWood,
                    amount = 5
                }
            };

            // Check and Set New Crafting Recipe and CanBeSalvaged Tag
            chest.objectInfo.requiredObjectsToCraft = newList;

            if(!chest.objectInfo.tags.Contains(ObjectCategoryTag.CanBeSalvaged))
                chest.objectInfo.tags.Add(ObjectCategoryTag.CanBeSalvaged);
        }
        /* Solarite Chest Modifications:
         - Change Recipe:
            - 5 Solarite Bars
            - 5 Coral Wood
         - Make Chest Salvageable
         */
        [EntityModification(ObjectID.SolariteChest)]
        private static void EditSolariteChest(Entity entity, GameObject authoring, EntityManager entityManager)
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
                    objectID = ObjectID.SolariteBar,
                    amount = 5
                },
                new CraftingObject
                {
                    objectID = ObjectID.GleamWood,
                    amount = 5
                }
            };

            // Check and Set New Crafting Recipe and CanBeSalvaged Tag
            chest.objectInfo.requiredObjectsToCraft = newList;

            if(!chest.objectInfo.tags.Contains(ObjectCategoryTag.CanBeSalvaged))
                chest.objectInfo.tags.Add(ObjectCategoryTag.CanBeSalvaged);
        }
        /* Ancient Chest Modifications:
         - Change Recipe:
            - 3 Metropolis Blocks
            - 2 Iron Bars
            - 1 Ancient Gemstone
            - 2 Mechanical Parts
         - Make Chest Salvageable
         */
        [EntityModification(ObjectID.InventoryAncientChest)]
        private static void EditAncientChest(Entity entity, GameObject authoring, EntityManager entityManager)
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
                    objectID = ObjectID.WallCityBlock,
                    amount = 3
                },
                new CraftingObject
                {
                    objectID = ObjectID.IronBar,
                    amount = 2
                },
                new CraftingObject
                {
                    objectID = ObjectID.AncientGemstone,
                    amount = 1
                },
                new CraftingObject
                {
                    objectID = ObjectID.MechanicalPart,
                    amount = 2
                }
            };

            // Check and Set New Crafting Recipe and CanBeSalvaged Tag
            chest.objectInfo.requiredObjectsToCraft = newList;

            if(!chest.objectInfo.tags.Contains(ObjectCategoryTag.CanBeSalvaged))
                chest.objectInfo.tags.Add(ObjectCategoryTag.CanBeSalvaged);
        }
        /* Golden Ancient Chest Modifications:
         - Change Recipe:
            - 3 Desert Temple Blocks
            - 2 Golden Bars
            - 1 Ancient Gemstone
            - 2 Mechanical Parts
         - Make Chest Salvageable
         */
        [EntityModification(ObjectID.InventoryDesertBiomeChest)]
        private static void EditGoldenAncientChest(Entity entity, GameObject authoring, EntityManager entityManager)
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
                    objectID = ObjectID.WallDesertTempleBlock,
                    amount = 3
                },
                new CraftingObject
                {
                    objectID = ObjectID.GoldBar,
                    amount = 2
                },
                new CraftingObject
                {
                    objectID = ObjectID.AncientGemstone,
                    amount = 1
                },
                new CraftingObject
                {
                    objectID = ObjectID.MechanicalPart,
                    amount = 2
                }
            };

            // Check and Set New Crafting Recipe and CanBeSalvaged Tag
            chest.objectInfo.requiredObjectsToCraft = newList;

            if(!chest.objectInfo.tags.Contains(ObjectCategoryTag.CanBeSalvaged))
                chest.objectInfo.tags.Add(ObjectCategoryTag.CanBeSalvaged);
        }
        /* Alien Chest Modifications:
         - Change Recipe:
            - 3 Alien Tech Blocks
            - 2 Pandorium Bars
            - 2 Ancient Gemstones
            - 2 Mechanical Parts
         - Make Chest Salvageable
         */
        [EntityModification(ObjectID.AlienChest)]
        private static void EditAlienChest(Entity entity, GameObject authoring, EntityManager entityManager)
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
                    objectID = ObjectID.WallAlienBlock,
                    amount = 3
                },
                new CraftingObject
                {
                    objectID = ObjectID.PandoriumBar,
                    amount = 2
                },
                new CraftingObject
                {
                    objectID = ObjectID.AncientGemstone,
                    amount = 2
                },
                new CraftingObject
                {
                    objectID = ObjectID.MechanicalPart,
                    amount = 2
                }
            };

            // Check and Set New Crafting Recipe and CanBeSalvaged Tag
            chest.objectInfo.requiredObjectsToCraft = newList;

            if(!chest.objectInfo.tags.Contains(ObjectCategoryTag.CanBeSalvaged))
                chest.objectInfo.tags.Add(ObjectCategoryTag.CanBeSalvaged);
        }
        /* Cultist Chest Modifications:
         - Change Recipe:
            - 3 Fossil Blocks
            - 5 Pandorium Bars
            - 1 Ancient Gemstones
            - 2 Mechanical Parts
         - Make Chest Salvageable
         */
        [EntityModification(ObjectID.PassageChest)]
        private static void EditCultistChest(Entity entity, GameObject authoring, EntityManager entityManager)
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
                    objectID = ObjectID.WallPassageBlock,
                    amount = 2
                },
                new CraftingObject
                {
                    objectID = ObjectID.PandoriumBar,
                    amount = 5
                },
                new CraftingObject
                {
                    objectID = ObjectID.AncientGemstone,
                    amount = 1
                },
                new CraftingObject
                {
                    objectID = ObjectID.MechanicalPart,
                    amount = 2
                }
            };

            // Check and Set New Crafting Recipe and CanBeSalvaged Tag
            chest.objectInfo.requiredObjectsToCraft = newList;

            if(!chest.objectInfo.tags.Contains(ObjectCategoryTag.CanBeSalvaged))
                chest.objectInfo.tags.Add(ObjectCategoryTag.CanBeSalvaged);
        }
        /* Larva Hive Chest Modifications:
         - Change Recipe:
            - 5 Larva Hive Blocks
            - 2 Fibers
            - 2 Mechanical Part
         - Make Chest Salvageable
         */
        [EntityModification(ObjectID.InventoryLarvaHiveChest)]
        private static void EditLarvaHiveChest(Entity entity, GameObject authoring, EntityManager entityManager)
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
                    objectID = ObjectID.WallHiveBlock,
                    amount = 3
                },
                new CraftingObject
                {
                    objectID = ObjectID.WallClayBlock,
                    amount = 2
                },
                new CraftingObject
                {
                    objectID = ObjectID.Fiber,
                    amount = 2
                },
                new CraftingObject
                {
                    objectID = ObjectID.MechanicalPart,
                    amount = 2
                }
            };

            // Check and Set New Crafting Recipe and CanBeSalvaged Tag
            chest.objectInfo.requiredObjectsToCraft = newList;

            if(!chest.objectInfo.tags.Contains(ObjectCategoryTag.CanBeSalvaged))
                chest.objectInfo.tags.Add(ObjectCategoryTag.CanBeSalvaged);
        }
        /* Mold Covered Chest Modifications:
         - Change Recipe:
            - 5 Mold Blocks
            - 2 Mold Vessels
            - 2 Mechanical Parts
         - Make Chest Salvageable
         */
        [EntityModification(ObjectID.InventoryMoldDungeonChest)]
        private static void EditMoldCoveredChest(Entity entity, GameObject authoring, EntityManager entityManager)
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
                    objectID = ObjectID.WallMoldBlock,
                    amount = 3
                },
                new CraftingObject
                {
                    objectID = ObjectID.IronBar,
                    amount = 2
                },
                new CraftingObject
                {
                    objectID = ObjectID.MoldDestructible,
                    amount = 1
                },
                new CraftingObject
                {
                    objectID = ObjectID.MechanicalPart,
                    amount = 2
                }
            };

            // Check and Set New Crafting Recipe and CanBeSalvaged Tag
            chest.objectInfo.requiredObjectsToCraft = newList;

            if(!chest.objectInfo.tags.Contains(ObjectCategoryTag.CanBeSalvaged))
                chest.objectInfo.tags.Add(ObjectCategoryTag.CanBeSalvaged);
        }
        /* Seashell Chest Modifications:
         - Change Recipe:
            - 2 Beach Blocks
            - 5 Seashells
            - 2 Mechanical Parts
         - Make Chest Salvageable
         */
        [EntityModification(ObjectID.InventorySeaBiomeChest)]
        private static void EditSeashellChest(Entity entity, GameObject authoring, EntityManager entityManager)
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
                    objectID = ObjectID.WallLimestoneBlock,
                    amount = 2
                },
                new CraftingObject
                {
                    objectID = ObjectID.SeaShell,
                    amount = 5
                },
                new CraftingObject
                {
                    objectID = ObjectID.MechanicalPart,
                    amount = 2
                }
            };

            // Check and Set New Crafting Recipe and CanBeSalvaged Tag
            chest.objectInfo.requiredObjectsToCraft = newList;
            
            if(!chest.objectInfo.tags.Contains(ObjectCategoryTag.CanBeSalvaged))
                chest.objectInfo.tags.Add(ObjectCategoryTag.CanBeSalvaged);
        }
        /* Smoldering Chest Modifications:
         - Change Recipe:
            - 2 Beach Blocks
            - 5 Seashells
            - 2 Mechanical Parts
         - Make Chest Salvageable
         */
        [EntityModification(ObjectID.InventoryLavaChest)]
        private static void EditSmolderingChest(Entity entity, GameObject authoring, EntityManager entityManager)
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
                    objectID = ObjectID.WallLavaBlock,
                    amount = 5
                },
                new CraftingObject
                {
                    objectID = ObjectID.LavaSlime,
                    amount = 2
                },
                new CraftingObject
                {
                    objectID = ObjectID.MechanicalPart,
                    amount = 2
                }
            };

            // Check and Set New Crafting Recipe and CanBeSalvaged Tag
            chest.objectInfo.requiredObjectsToCraft = newList;
                
            if(!chest.objectInfo.tags.Contains(ObjectCategoryTag.CanBeSalvaged))
                chest.objectInfo.tags.Add(ObjectCategoryTag.CanBeSalvaged);
        }
    }
}