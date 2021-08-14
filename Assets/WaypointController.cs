using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Fonte: https://github.com/nostalgicbear/WaypointTutorial/blob/master/Assets/WaypointController.cs */

public class WaypointController : MonoBehaviour {
    /* Lista de waypoints */
    public List<Transform> waypoints = new List<Transform>();
    
    /* Proximo waypoint */
    private Transform targetWaypoint;
    private int targetWaypointIndex = 0;
    
    
    private float minDistance = 0.1f; //If the distance between the enemy and the waypoint is less than this, then it has reacehd the waypoint
    private int lastWaypointIndex;

    public float movementSpeed;
    public float rotationSpeed;
    public GameObject LapTimer;

    /* Roda na inicializacao */
	void Start () {
        /* Obtem ultimo e primeiro waypoints */
        lastWaypointIndex = waypoints.Count - 1;
        targetWaypoint = waypoints[targetWaypointIndex];
	}
	
	/* Roda a cada frame */
	void Update () {

        /* Evita update enquanto a corrida nao comecar */
        if (LapTimer.activeSelf == false) {
            return;
        }

        float movementStep = movementSpeed * Time.deltaTime;
        float rotationStep = rotationSpeed * Time.deltaTime;

        Vector3 directionToTarget = targetWaypoint.position - transform.position;
        Quaternion rotationToTarget = Quaternion.LookRotation(directionToTarget); 

        transform.rotation = Quaternion.Slerp(transform.rotation, rotationToTarget, rotationStep); 

        float distance = Vector3.Distance(transform.position, targetWaypoint.position);
        CheckDistanceToWaypoint(distance);

        transform.position = Vector3.MoveTowards(transform.position, targetWaypoint.position, movementStep);
	}

    
    void CheckDistanceToWaypoint(float currentDistance)
    {
        if(currentDistance <= minDistance)
        {
            targetWaypointIndex++;

            if(targetWaypointIndex > lastWaypointIndex) {
                targetWaypointIndex = 0;
            }

            targetWaypoint = waypoints[targetWaypointIndex];

        }
    }
}