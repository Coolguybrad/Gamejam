using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LevelGen
{
    public class CreateRandom : MonoBehaviour
    {
        public List<GameObject> spawnablePF = new List<GameObject>();

        private void OnEnable() //used to spawn a random gameobject selected from a list provided in the inspector at the specified location of the transform this script is attached to
        {
            GameObject gOSpawn = spawnablePF[Random.Range(0, spawnablePF.Count)];
            Instantiate(gOSpawn, transform.position, transform.rotation, GameObject.FindWithTag("EnviroContainer").transform);
        }

    }
}
