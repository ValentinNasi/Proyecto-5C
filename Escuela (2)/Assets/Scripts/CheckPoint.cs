using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    public Transform siguientePunto;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "NPC")
        {
            other.gameObject.GetComponent<ControladorNavMesh>().objetivo = siguientePunto;
        }
    }
}
