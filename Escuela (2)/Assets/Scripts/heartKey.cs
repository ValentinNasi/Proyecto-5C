using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heartKey : MonoBehaviour
{
    public static bool inTrigger;

    void Awake()
    {
        this.gameObject.SetActive(false);    
    }
    void Start()
    {
        Demonio.heart = false;
        inTrigger = false;
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            inTrigger = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        inTrigger = false;
    }
    void OnGUI()
    {
        if (inTrigger)
        {
            if (Demonio.heart == false)
            {
                GUI.Box(new Rect(0, 60, 300, 25), "Presiona E agarrar el corazon");
                if (Input.GetKeyDown(KeyCode.E))
                {
                    Destroy(this.gameObject);
                    Demonio.heart = true;
                }
            }
           
              
        }
    }
}
