using System.Collections.Generic;
using NaughtyAttributes;
using Pug.UnityExtensions;
using UnityEngine;

namespace ChestsGalore.Scripts.Components
{
    [DisallowMultipleComponent]
    public class ModReskinCondition : MonoBehaviour
    {
        public GameObject BuildingPrefab => GetComponent<ObjectAuthoring>().graphicalPrefab;
        
        [InfoBox("The sprites are re-skinned based on the first matching entry." +
                 "If none match, the default skin is used. Each entry in the reskin list applies to the corresponding sprite in the spritesToReskin list.")]
        [Header("Reskin Condition")]
        public bool dependsOnVariation;
        [AllowNesting]
        [ShowIf("dependsOnVariation")]
        public int variation;
        [Tooltip("None matches any season.")]
        public Season season;
        [Tooltip("If null, the sprite's corresponding default is used.")]
        public List<SpriteSkinFromEntityAndSeason.SkinAndGradientMap> reskin;

        public void OnValidate()
        {
            if (BuildingPrefab is null) return;
            SpriteSkinFromEntityAndSeason skin = BuildingPrefab.GetComponent<SpriteSkinFromEntityAndSeason>();
            SpriteSkinFromEntityAndSeason.SkinAndGradientMap elementToFillOutWith = reskin.Count <= 0 ? new SpriteSkinFromEntityAndSeason.SkinAndGradientMap() : reskin[^1];
            int count = skin.spritesToReskin.Count;
            reskin.Resize(elementToFillOutWith, count);
        }
    }
}