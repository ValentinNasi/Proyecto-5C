using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaloSigueBueno : MonoBehaviour
{
    public float radioVision;
    public float velocidad;

    GameObject player;

    Vector3 posicionInicial;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");

        posicionInicial = transform.position;
    }

    void Update()
    {
        Vector3 objetivo = posicionInicial;

        float distancia = Vector3.Distance(player.transform.position, transform.position);

        if(distancia < radioVision)
        {
            objetivo = player.transform.position;

        }
        float fixedVelocidad = velocidad * Time.deltaTime;

        transform.position = Vector3.MoveTowards(transform.position, objetivo, fixedVelocidad);



        
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, radioVision);
    }

}
