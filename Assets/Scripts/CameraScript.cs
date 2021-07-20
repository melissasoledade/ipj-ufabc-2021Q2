using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{

    public GameObject player;
    public float playerX;
    public float playerY;
    public float playerZ;

    // Start is called before the first frame update
    /*void Start()
    {
        
    }*/

    // Update is called once per frame
    void Update()
    {
     playerX = player.transform.eulerAngles.x;
     playerY = player.transform.eulerAngles.y;
     playerZ = player.transform.eulerAngles.z;

     transform.eulerAngles = new Vector3(playerX-playerX, playerY, playerZ-playerZ);

    }
}
