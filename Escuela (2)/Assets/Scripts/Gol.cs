using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gol : MonoBehaviour
{
    public bool inTrigger;
    public GameObject clipboard;
    
    void Start()
    {
       
        clipboard.SetActive(false);
        inTrigger = false;
        
    }

    void Update()
    {
       
        if (inTrigger)
        {
            if(PuertaSiguienteNivelGym.doorKey == false)
            {                            
                clipboard.SetActive(true);
                inTrigger = false;                           
            }
            
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Pelota")
        {
            inTrigger = true;
        }
        
    }
}
