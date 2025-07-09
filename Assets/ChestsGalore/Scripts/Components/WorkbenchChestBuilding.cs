using CoreLib.Util.Extensions;
using UnityEngine;

namespace ChestsGalore.Scripts.Components
{
    public class WorkbenchChestBuilding : SimpleCraftingBuilding
    {
        public override void OnOccupied()
        {
            GameObject mainWorkbench =
                ChestsGalore.ModChestWorkbenches.Find(x => x.GetEntityObjectID() == objectData.objectID);
            SpriteSkinFromEntityAndSeason skin = GetComponent<SpriteSkinFromEntityAndSeason>();
            craftingUIOverrideSettings.Clear();
            if (mainWorkbench is not null)
            {
                ObjectID objectID = mainWorkbench.GetEntityObjectID();
                ModCraftingUISetting setting = mainWorkbench.GetComponent<ModCraftingUISetting>();
                
                if (setting is not null)
                {
                    craftingUITitle = setting.craftingUITitle;
                    craftingUITitleLeftBox =  setting.craftingUITitleLeftBox;
                    craftingUITitleRightBox = setting.craftingUITitleRightBox;
                    craftingUIBackgroundVariation = setting.craftingUIBackgroundVariation;
                }
                ModCraftingAuthoring modCraftingAuthoring = mainWorkbench.GetComponent<ModCraftingAuthoring>();
                foreach (ModCraftingAuthoring building in modCraftingAuthoring.includeCraftedObjectsFromBuildings)
                {
                    ModCraftingUISetting buildingSetting = building.GetComponent<ModCraftingUISetting>();
                    if (buildingSetting is null) continue;
                    CraftingUISettings newSetting = new
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
                ModReskinCondition reSkin = mainWorkbench.GetComponent<ModReskinCondition>();
                if (reSkin is not null)
                {
                    SpriteSkinFromEntityAndSeason.ReskinCondition newSkin = new()
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
                }
            }
            skin?.UpdateGraphicsFromObjectInfo(objectInfo);
            base.OnOccupied();
        }
    }
}