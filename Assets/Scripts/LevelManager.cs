using System.Buffers.Text;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LevelGen
{
    public class LevelManager : MonoBehaviour
    {
        #region FIELDS
        public GameObject regionPF;
        public int regionCount;
        #endregion

        #region UNITY METHODS
        public void OnEnable()
        {
            SpawnRegion();
        }

        public void Update() //deletes empty platform prefabs that were used as templates for random generation
        {
            Destroy(GameObject.Find("PlatformRegionPF(Clone)"));
        }

        public void OnTriggerEnter(Collider other)  //spawns a new region pf when player passes a point
        {
            if (other.CompareTag("Player"))
            {
                transform.position = new Vector3(0, 4, transform.position.z + 60);
                SpawnRegion();
            }
        }
        #endregion

        #region METHODS

        public void SpawnRegion()   //logic to spawn the template prefab region
        {
            Vector3 regionPFSPawn = new Vector3(0, 0, regionCount * 60 + 10);

            GameObject newRegion = Instantiate(regionPF, regionPFSPawn, transform.rotation);

            regionCount++;
        }
        #endregion
    }

}
