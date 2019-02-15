//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class WaypointScript : MonoBehaviour {

	NavMeshAgent r;

	public Transform[] Waypoints;
	public int current;
	public float stop_distance;

	// Use this for initialization
	void Start () {
		r = GetComponent<NavMeshAgent>();
		r.stoppingDistance = stop_distance;
		
	}
	
	// Update is called once per frame
	void Update () {
		float distance = Vector3.Distance (transform.position, Waypoints[current].position);
		transform.LookAt (Waypoints[current]);

		if (distance <= stop_distance) {
			current += 1;
		}

		if (current >= Waypoints.Length) {
			current = 0; 
		}
		//move to First cube
		if (current == 0) {
			r.SetDestination(Waypoints[0].position);
		}
		//move to Second cube
			if (current == 1) {
				r.SetDestination(Waypoints[1].position);
			}
			// move to Third cube 
			if (current == 2) {
				r.SetDestination(Waypoints [2].position);
			}
		// move to Fourth cube 
		if (current == 3) {
			r.SetDestination(Waypoints [3].position);
		}
		}
	}
