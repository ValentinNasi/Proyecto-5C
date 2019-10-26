using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Demonio : MonoBehaviour
{
    public bool inTrigger;
    public GameObject varita;
    public static bool heart;
    void Start()
    {
        heart = false;
    }

    //public bool inTrigger;
  

    void Awake()
    {
        
        //varita.SetActive(false);

    }

    void Update()
    {
        if (inTrigger)
        {
            if (heart)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    varita.SetActive(true);
                    inTrigger = false;
                    Destroy(this.gameObject);
                }
            }
           
        }
       
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
            if (heart)
            {
                GUI.Box(new Rect(0, 60, 230, 25), "Presiona E para realizar el trato");
            }
            else
            {
                GUI.Box(new Rect(0, 60, 500, 25), "Traeme el corazon que esta al final del laberinto y tendremos un trato");
            }
            
        }
    }
}
