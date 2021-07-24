using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoostSpeed : MonoBehaviour {
    public GameObject car_root;

    void OnTriggerEnter() {
        /* Define a velocidade para 50km/h */
        int boostSpeed = 50;
        Vector3 v = car_root.GetComponent<Rigidbody>().velocity.normalized;
        car_root.GetComponent<Rigidbody>().velocity = new Vector3(v.x * boostSpeed, v.y * boostSpeed, v.z * boostSpeed);
        Debug.Log("entered");
    }
}
