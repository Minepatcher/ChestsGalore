using System.Collections.Generic;
using CoreLib.Localization;

namespace ChestsGalore.Scripts
{
    public class Localization
    {
        public static void LocalizeAllTerms()
        {
            // Items
            LocalizationModule.AddTerm("Items/ChestsGalore:WorkbenchChest", new Dictionary<string, string>
            {
                { "en", "Chest Workbench" }
            });
            LocalizationModule.AddTerm("Items/ChestsGalore:WorkbenchChestDesc", new Dictionary<string, string>
            {
                { "en", "Creates All Basic Chests" }
            });
            LocalizationModule.AddTerm("Items/ChestsGalore:WorkbenchDoubleChest", new Dictionary<string, string>
            {
                { "en", "Double Chest Workbench" }
            });
            LocalizationModule.AddTerm("Items/ChestsGalore:WorkbenchDoubleChestDesc", new Dictionary<string, string>
            {
                { "en", "Creates Double Chests" }
            });
            LocalizationModule.AddTerm("Items/ChestsGalore:WorkbenchDoubleChestExtra", new Dictionary<string, string>
            {
                { "en", "Double Chest Workbench" }
            });
            LocalizationModule.AddTerm("Items/ChestsGalore:WorkbenchDoubleChestExtraDesc", new Dictionary<string, string>
            {
                { "en", "Creates Double Chests" }
            });
            LocalizationModule.AddTerm("Items/ChestsGalore:WorkbenchMagicChest", new Dictionary<string, string>
            {
                { "en", "Magic Chest Workbench" }
            });
            LocalizationModule.AddTerm("Items/ChestsGalore:WorkbenchMagicChestDesc", new Dictionary<string, string>
            {
                { "en", "Creates Magically Expanded Chests" }
            });
            LocalizationModule.AddTerm("Items/ChestsGalore:MagicChest", new Dictionary<string, string>
            {
                { "en", "Magic Chest" }
            });
            LocalizationModule.AddTerm("Items/ChestsGalore:MagicChestDesc", new Dictionary<string, string>
            {
                { "en", "Your hard work has finally paid off and you have made a compact chest of incredible size!\n" +
                        "Wait...I think it can power things as well???" }
            });
            
            // Workbench Titles
            LocalizationModule.AddTerm("ChestsGalore/WorkbenchChestTextLeft", new Dictionary<string, string>
            {
                { "en", "Basic\nChests" }
            });
            LocalizationModule.AddTerm("ChestsGalore/WorkbenchChestTextCenter", new Dictionary<string, string>
            {
                { "en", "Advanced\nChests" }
            });
            LocalizationModule.AddTerm("ChestsGalore/WorkbenchChestTextRight", new Dictionary<string, string>
            {
                { "en", "Special\nChests" }
            });
            LocalizationModule.AddTerm("ChestsGalore/WorkbenchDoubleChestTextLeft", new Dictionary<string, string>
            {
                { "en", "Slime\nBosses" }
            });
            LocalizationModule.AddTerm("ChestsGalore/WorkbenchDoubleChestTextCenter", new Dictionary<string, string>
            {
                { "en", "Insect\nBosses" }
            });
            LocalizationModule.AddTerm("ChestsGalore/WorkbenchDoubleChestTextRight", new Dictionary<string, string>
            {
                { "en", "Titan\nBosses" }
            });
            LocalizationModule.AddTerm("ChestsGalore/WorkbenchDoubleChestExtraTextLeft", new Dictionary<string, string>
            {
                { "en", "Caveling\nBosses" }
            });
            LocalizationModule.AddTerm("ChestsGalore/WorkbenchDoubleChestExtraTextCenter", new Dictionary<string, string>
            {
                { "en", "Funny\nError" }
            });
            LocalizationModule.AddTerm("ChestsGalore/WorkbenchDoubleChestExtraTextRight", new Dictionary<string, string>
            {
                { "en", "Core\nBosses" }
            });
            LocalizationModule.AddTerm("ChestsGalore/WorkbenchMagicChestTextCenter", new Dictionary<string, string>
            {
                { "en", "Magic\nChests" }
            });
            //Next Workbench Title
            LocalizationModule.AddTerm("ChestsGalore/WorkbenchChestNextTextCenter", new Dictionary<string, string>
            {
                { "en", "Next\nWorkbench" }
            });
            
            //Creative UI Item Categories
            LocalizationModule.AddTerm("ItemCategory/ChestsGaloreMod", new Dictionary<string, string>
            {
                { "en", "Chests Galore" }
            });
            LocalizationModule.AddTerm("ItemCategory/ChestsGaloreMod_Workbench", new Dictionary<string, string>
            {
                { "en", "Workbench" }
            });
            LocalizationModule.AddTerm("ItemCategory/ChestsGaloreMod_Chest", new Dictionary<string, string>
            {
                { "en", "Chest" }
            });
        }
    }
}