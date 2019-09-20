using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gol : MonoBehaviour
{
    public bool inTrigger;
    public GameObject clipboard;
    
    void Awake()
    {
       
        clipboard.SetActive(false);
        
    }

    void Update()
    {
       
            if (inTrigger)
            {
                clipboard.SetActive(true);
            }
        /* if (PuertaSiguienteNivel.doorKey == true)
         {
             clipboard.SetActive(false);

             Destroy(clipboard);
         }*/


        if (ClipBoardKey.inTrigger)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                clipboard.SetActive(false);
                PuertaSiguienteNivel.doorKey = true;
                //Destroy(clipboard);

            }
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        inTrigger = true;
    }
    /*private void OnTriggerExit(Collider other)
    {
        inTrigger = true;
    }*/
}
