using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class ControladorNavMesh : MonoBehaviour
{
    public NavMeshAgent agente;
    public Transform objetivo;


    void Start()
    {
        if(agente == null)
        {
            agente = this.gameObject.GetComponent<NavMeshAgent>();
        }
    }

    void Update()
    {
        agente.SetDestination(objetivo.position);
    }
}
