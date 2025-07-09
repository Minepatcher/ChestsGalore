using System.Collections.Generic;
using System.Linq;
using CoreLib.Util.Extensions;
using Pug.UnityExtensions;
using PugConversion;
using PugMod;
using UnityEngine;

namespace ChestsGalore.Scripts.Components
{
  [DisallowMultipleComponent]
    public class ModCraftingAuthoring : MonoBehaviour
    {
        public CraftingType craftingType;
        public bool showLoopEffectOnOutputSlot;

        [ArrayElementTitle("objectName, amount")]
        public List<InventoryItemAuthoring.CraftingObject> canCraftObjects;
        [ArrayElementTitle("craftingAuthoring, modCraftingAuthoring")]
        public List<ModCraftingAuthoring> includeCraftedObjectsFromBuildings;
        private void OnValidate()
        {
            for (int index = 0; index < canCraftObjects.Count; ++index)
            {
                if (canCraftObjects[index].amount <= 0)
                  canCraftObjects[index] = new InventoryItemAuthoring.CraftingObject
                    {
                        objectName = canCraftObjects[index].objectName,
                        amount = 1
                    };
            }
        }
    }

  public class ModCraftingAuthoringConverter : SingleAuthoringComponentConverter<ModCraftingAuthoring>
    {
        protected override void Convert(ModCraftingAuthoring craftingAuthoring)
        {
          if (craftingAuthoring.GetEntityObjectID() == ObjectID.None) return;
          AddComponentData(new PugTimerUserCD
          {
            triggerType = typeof (CraftingTimerTriggerCD)
          });
          EnsureHasComponent<PugTimerRefCD>();
          int num = -1;
          if (TryGetActiveComponent(craftingAuthoring, out InventoryAuthoring _))
            num = AddToBuffer(new ContainedObjectsBuffer());
          AddComponentData(new CraftingCD
          {
            currentlyCraftingIndex = -1,
            craftingType = craftingAuthoring.craftingType,
            outputSlotIndex = num,
            showLoopEffectOnOutputSlot = craftingAuthoring.showLoopEffectOnOutputSlot
          });
          CraftingCD.IsProcessAutoCrafter(craftingAuthoring.craftingType);
          EnsureHasBuffer<CanCraftObjectsBuffer>();
          foreach (InventoryItemAuthoring.CraftingObject canCraftObject in craftingAuthoring.canCraftObjects)
            AddToBuffer(new CanCraftObjectsBuffer
            {
              objectID = API.Authoring.GetObjectID(canCraftObject.objectName),
              amount = Mathf.Max(1, canCraftObject.amount),
              entityAmountToConsume = 0,
              allowCraftingNone = false,
              craftingTimeOverride = 0
            });
          if (craftingAuthoring.includeCraftedObjectsFromBuildings == null) return;
          foreach (InventoryItemAuthoring.CraftingObject canCraftObject in craftingAuthoring.includeCraftedObjectsFromBuildings.Where(objectsFromBuilding => objectsFromBuilding?.canCraftObjects != null).SelectMany(objectsFromBuilding => objectsFromBuilding.canCraftObjects))
          {
            AddToBuffer(new CanCraftObjectsBuffer
            {
              objectID = API.Authoring.GetObjectID(canCraftObject.objectName),
              amount = Mathf.Max(1, canCraftObject.amount),
              entityAmountToConsume = 0,
              allowCraftingNone = false,
              craftingTimeOverride = 0
            });
          }
          if (craftingAuthoring.includeCraftedObjectsFromBuildings.Count <= 0) return;
          EnsureHasBuffer<IncludedCraftingBuildingsBuffer>();
          AddToBuffer(new IncludedCraftingBuildingsBuffer
          {
            objectID = (ObjectID) ObjectIndex,
            amountOfCraftingOptions = craftingAuthoring.canCraftObjects.Count
          });
          foreach (ModCraftingAuthoring objectsFromBuilding in craftingAuthoring.includeCraftedObjectsFromBuildings)
          {
            ObjectID objectId = objectsFromBuilding.GetEntityObjectID();
            if (objectId == ObjectID.None) continue;
            AddToBuffer(new IncludedCraftingBuildingsBuffer
            {
              objectID = objectId,
              amountOfCraftingOptions = objectsFromBuilding.canCraftObjects.Count
            });
          }
        }
    }
}