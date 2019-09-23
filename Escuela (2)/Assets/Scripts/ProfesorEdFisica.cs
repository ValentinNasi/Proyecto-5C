using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ProfesorEdFisica : MonoBehaviour
{
    public NavMeshAgent agente;
    GameObject player;
    public float radioVision;


    void Start()
    {
        if (agente == null)
        {
            agente = this.gameObject.GetComponent<NavMeshAgent>();
        }

        player = GameObject.FindGameObjectWithTag("Player");
    }

    void OnGUI()
    {

        float distancia = Vector3.Distance(player.transform.position, transform.position);

        if (distancia < radioVision)
        {           
                GUI.Box(new Rect(0, 0, 400, 25), "Profesor: -Daleeeee, mete un gol asi podemos irnos al aula-");                
        }
       /* else
        {
                 GUI.Box(new Rect(0, 0, 400, 25), "Convierte un gol para volver a tu aula del colegio");
        }
        */
    }
    void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, radioVision);
    }
}
