using CoreLib.Util.Extensions;
using UnityEngine;

namespace ChestsGalore.Scripts.Components
{
    public class WorkbenchChestBuilding : SimpleCraftingBuilding
    {
        public override void OnOccupied()
        {
            var mainWorkbench = ChestsGalore.ChestGaloreEntities.Find(x => x.GetEntityObjectID() == objectData.objectID);
            var skin = GetComponent<SpriteSkinFromEntityAndSeason>();
            if (mainWorkbench is not null)
            {
                var objectID = mainWorkbench.GetEntityObjectID();
                var setting = mainWorkbench.GetComponent<ModCraftingUISetting>();
                
                if (setting is not null)
                {
                    craftingUITitle = setting.craftingUITitle;
                    craftingUITitleLeftBox =  setting.craftingUITitleLeftBox;
                    craftingUITitleRightBox = setting.craftingUITitleRightBox;
                    craftingUIBackgroundVariation = setting.craftingUIBackgroundVariation;
                }
                var modCraftingAuthoring = mainWorkbench.GetComponent<ModCraftingAuthoring>();
                foreach (var building in modCraftingAuthoring.includeCraftedObjectsFromBuildings)
                {
                    var buildingSetting = building.GetComponent<ModCraftingUISetting>();
                    if (buildingSetting is null) continue;
                    var newSetting = new CraftingUISettings
                    (
                        building.GetEntityObjectID(),
                        buildingSetting.craftingUITitle,
                        buildingSetting.craftingUITitleLeftBox,
                        buildingSetting.craftingUITitleRightBox,
                        buildingSetting.craftingUIBackgroundVariation
                    
                    );
                    if(!craftingUIOverrideSettings.Contains(newSetting))
                        craftingUIOverrideSettings.Add(newSetting);
                }
                var reSkin = mainWorkbench.GetComponent<ModReskinCondition>();
                if (reSkin is not null)
                {
                    var newSkin = new SpriteSkinFromEntityAndSeason.ReskinCondition
                    {
                        objectID = objectID,
                        dependsOnVariation = reSkin.dependsOnVariation,
                        variation = reSkin.variation,
                        season = reSkin.season,
                        reskin = reSkin.reskin
                    };
                    // ReSharper disable once UsageOfDefaultStructEquality
                    if(!skin.reskinConditions.Contains(newSkin))
                        skin.reskinConditions.Add(newSkin);
                    skin.UpdateGraphicsFromObjectInfo(objectInfo);
                }
            }
            base.OnOccupied();
        }
    }
}