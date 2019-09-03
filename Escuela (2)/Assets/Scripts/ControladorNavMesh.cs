using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class ControladorNavMesh : MonoBehaviour
{
    public NavMeshAgent agente;
    public Transform objetivo;
    public float radioVision;
    public float velocidad;

    GameObject player;

    void Start()
    {
        if(agente == null)
        {
            agente = this.gameObject.GetComponent<NavMeshAgent>();
        }

        player = GameObject.FindGameObjectWithTag("Player");

    }

    void Update()
    {
        agente.SetDestination(objetivo.position);

        float distancia = Vector3.Distance(player.transform.position, transform.position);

        if (distancia < radioVision)
        {
            agente.SetDestination(player.transform.position);
        }
        else
        {
            agente.SetDestination(objetivo.position);
        }
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, radioVision);
    }
}
