using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{

    [SerializeField]
    private GameObject player;

    void Update()
    {
        this.gameObject.transform.position = new Vector3(this.gameObject.transform.position.x, player.transform.position.y+1, this.gameObject.transform.position.z); //follows player's Y position


    }
}