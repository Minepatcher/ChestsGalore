using System.Collections.Generic;
using System.Linq;
using CoreLib.Util.Extensions;
using PugMod;
using UnityEngine;

namespace ChestsGalore.Scripts.ScriptableObjects
{
  [CreateAssetMenu(menuName = "ScriptableObjects/ModObjectIDCategory", fileName = "ModObjectIDCategory", order = 0)]
  public class ModObjectIDCategory : ScriptableObject
  {
    public string category;
    public Sprite icon;
    public List<string> objectIds;

    public ObjectIDCategory GetObjectIDCategory()
    {
      var newCategory = Instantiate(CreateInstance<ObjectIDCategory>());
      newCategory.name = name;
      newCategory.category = category;
      newCategory.icon = icon;
      newCategory.hideFlags = hideFlags;
      var objects = newCategory.GetValue<List<ObjectID>>("objectIds");
      objects ??= new List<ObjectID>();
      objects.AddRange(objectIds.Select(objectID => API.Authoring.GetObjectID(objectID)));
      if (objects.Count <= 0) return newCategory;
      newCategory.SetValue("objectIds", objects);
      return newCategory;
    }
  }
}
