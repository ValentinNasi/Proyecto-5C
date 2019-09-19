using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatearPelota : MonoBehaviour
{
    public float fuerza;
    public float x;
    public Rigidbody pelota;
    void Start()
    {
        
    }


    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            pelota.gameObject.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(x, 0, 1) * fuerza, ForceMode.Impulse);
        }
    }
   /* void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if(hit.gameObject.tag == "Player")
        {
            pelota.gameObject.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(x, 0, 1) * fuerza, ForceMode.Impulse); 
        }
    }*/
}
