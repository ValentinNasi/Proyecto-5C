using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaloSigueBueno : MonoBehaviour
{
    public float radioVision;
    public float velocidad;
    int check = 0;
    GameObject player;
    static Vector3 objetivo;
    Vector3 posicionInicial;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");

        posicionInicial = transform.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "ZonaAtrapar")
        {
            this.gameObject.tag = "Atrapado";
        }
    }

    void Update()
    {
        objetivo = posicionInicial;

        float distancia = Vector3.Distance(player.transform.position, transform.position);
        if (gameObject.tag == "Atrapado")
        {
            
            if(check == 0)
            {
                objetivo = GameObject.FindGameObjectWithTag("A1").gameObject.transform.position;
                check++;
            }
            else
            {
                objetivo = GameObject.FindGameObjectWithTag("A2").gameObject.transform.position;
            }
          
            transform.position = Vector3.MoveTowards(transform.position, objetivo, (2*Time.deltaTime));
        }
        else
        {
            if (distancia < radioVision)
            {
                objetivo = player.transform.position;
            }
            float fixedVelocidad = velocidad * Time.deltaTime;

            transform.position = Vector3.MoveTowards(transform.position, objetivo, fixedVelocidad);
        }       
    }



    void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, radioVision);
    }

}
