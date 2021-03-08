using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Continuo : MonoBehaviour
{
    public List<Vector3> points;
    NavMeshAgent agent;

    int index = 0;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        agent.SetDestination(points[index]);
        if(transform.position == points[index])
        {
            index++;
        }

        if (index >= points.Count)
        {
            index = 0;
        }
    }
}
