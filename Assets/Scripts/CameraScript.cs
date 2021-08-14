// Script utilizado para a câmera acompanhar a visão do player 
// Main camera é "filho" de Player (objeto denominado 'car_root' no unity)

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{

    public GameObject player;
    public float playerX;
    public float playerY;
    public float playerZ;
    public Camera cameraFront;
    public Camera cameraBack;

    void Update()
    {
     playerX = player.transform.eulerAngles.x;
     playerY = player.transform.eulerAngles.y;
     playerZ = player.transform.eulerAngles.z;

     transform.eulerAngles = new Vector3(0, playerY, 0);

     if (Input.GetKey("b")) {
         cameraFront.enabled = false;
         cameraBack.enabled = true;
     } else {
         cameraFront.enabled = true;
         cameraBack.enabled = false;         
     }

    }
}
