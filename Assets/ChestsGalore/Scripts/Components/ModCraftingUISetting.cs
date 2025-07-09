using I2.Loc;
using UnityEngine;

namespace ChestsGalore.Scripts.Components
{
    [DisallowMultipleComponent]
    public class ModCraftingUISetting : MonoBehaviour
    {
        public GameObject BuildingPrefab => GetComponent<ObjectAuthoring>().graphicalPrefab;
        
        [Header("Crafting Building Settings")]
        
        [Tooltip("Center Window Title in Crafting Buildings")]
        public LocalizedString craftingUITitle;
        
        [Tooltip("Left Window Title in Crafting Buildings")]
        public LocalizedString craftingUITitleLeftBox;
        
        [Tooltip("Right Window Title in Crafting Buildings")]
        public LocalizedString craftingUITitleRightBox;
        
        [Tooltip("Background Skin Variation")]
        public UIManager.CraftingUIThemeType craftingUIBackgroundVariation;
    }
}