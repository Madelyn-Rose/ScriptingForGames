using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.AI;
public class PatrolAI : MonoBehaviour
{
    public Transform[] waypoints;
    private int currentWaypointIndex;
    private NavMeshAgent agent;
    // Start is called before the first frame update
    private void Start()
    {
        agent.updateRotation = false;
        agent = GetComponent<NavMeshAgent>();
        if (waypoints.Length > 0)
        {
            agent.SetDestination(waypoints[0].position);
        }
    }

    // Update is called once per frame
    private void Update()
    {
        if (agent.remainingDistance < agent.stoppingDistance)
        {
            currentWaypointIndex = (currentWaypointIndex + 1) % waypoints.Length;
            agent.SetDestination(waypoints[currentWaypointIndex].position);
        }
    }
}
