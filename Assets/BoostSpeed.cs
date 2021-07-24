using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoostSpeed : MonoBehaviour {
    /* Baseado na documentacao em https://docs.unity3d.com/ScriptReference/Rigidbody.AddRelativeForce.html */
    public float thrust = 200000000000000;
    public GameObject car_root;

    void OnTriggerEnter() {
        Vector3 v = car_root.GetComponent<Rigidbody>().velocity.normalized;
        car_root.GetComponent<Rigidbody>().velocity = new Vector3(v.x * 50, v.y * 50, v.z * 50);
        Debug.Log("entered");
    }
}
