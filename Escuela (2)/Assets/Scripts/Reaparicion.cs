using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reaparicion : MonoBehaviour
{
    public GameObject puntoreaparicion;
    void Start()
    {
        
    }

    void Update()
    {
    }

   /* void OnTriggerEnter(Collider other)
    {

        if(other.gameObject.tag == "Player")
        {
            Debug.Log("Se tocan");
            other.gameObject.transform.position  = puntoreaparicion.transform.position;
        }
    }
    */
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.tag == "NPC")
        {
            Debug.Log("Se tocan");
            this.gameObject.transform.position = puntoreaparicion.transform.position;
        }
    }
   
}
