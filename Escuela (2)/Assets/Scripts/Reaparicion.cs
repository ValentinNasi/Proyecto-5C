using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reaparicion : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "NPC")
        {
            this.gameObject.transform.position = new Vector3(-11, 1, 20);
        }
    }
}
