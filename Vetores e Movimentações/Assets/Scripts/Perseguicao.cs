using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Perseguicao : MonoBehaviour
{
    NavMeshAgent agent;
    public GameObject perseguido;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }


    void Update()
    {
        agent.destination = perseguido.transform.position;
    }
}
