using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullys : MonoBehaviour
{
    public float radioVision;
    public float velocidad;
    bool activador = false;
    GameObject player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");

    }

    void Update()
    {
        
        float distancia = Vector3.Distance(player.transform.position, transform.position);

         float fixedVelocidad = velocidad * Time.deltaTime;
        if (activador)
        {
            transform.position = Vector3.MoveTowards(transform.position, player.transform.position, fixedVelocidad);
        }

        if (distancia < radioVision)
        {
            activador = true;          
        }
       

        
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, radioVision);
    }


}
