using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Demonio : MonoBehaviour
{
    public bool inTrigger;

    void Start()
    {
        
    }

    void Update()
    {
        
    }
    
    void OnTriggerEnter(Collider other)
    {
        inTrigger = true;
    }

    void OnTriggerExit(Collider other)
    {
        inTrigger = false;
    }
    void OnGUI()
    {
        if (inTrigger)
        {
            GUI.Box(new Rect(0, 60, 300, 25), "Traeme 2 vidas humanas y haremos un trato");
        }
    }
}
