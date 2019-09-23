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
            inTrigger = false;
        }

        if (ClipBoardKey.inTrigger)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
               // clipboard.SetActive(false);
                PuertaSiguienteNivelGym.doorKey = true;
                Destroy(clipboard);

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
