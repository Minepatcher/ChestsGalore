/* Taken from Moorowl's Paintable Double Chest https://mod.io/g/corekeeper/m/doublechest#description */
using UnityEngine;

namespace ChestsGalore.Scripts.Poolable {
	public class PooledGraphicalObject : MonoBehaviour {
		public int initialSize = 16;
		public int maxFreeSize = 16;
		public int maxSize = 1024;

		public PoolablePrefabBank.PoolablePrefab GetPoolablePrefab() {
			return new PoolablePrefabBank.PoolablePrefab {
				prefab = gameObject,
				initialSize = initialSize,
				maxFreeSize = maxFreeSize,
				maxSize = maxSize
			};
		}
	}
}