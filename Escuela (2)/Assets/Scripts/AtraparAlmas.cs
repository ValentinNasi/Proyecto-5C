using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtraparAlmas : MonoBehaviour
{  
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "NPC")
        {
            other.gameObject.tag = tag;
        }  
    }
}
