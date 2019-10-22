using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoderVarita : MonoBehaviour
{
    public static bool varita = false;
    public static bool inTrigger;
    public GameObject NPC1;
    public GameObject NPC2;
    public GameObject NPC3;
    public GameObject NPC4;
    public static bool todolisto = false;
    void Update()
    {
       
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ActivacionVarita")
        {
            if (varita)
            {
                inTrigger = true;
            }
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
            GUI.Box(new Rect(0, 60, 300, 25), "Presiona X para destruir");
            if (Input.GetKeyDown(KeyCode.X))
            {
                Destroy(NPC1);
                Destroy(NPC2);
                Destroy(NPC3);
                Destroy(NPC4);
                todolisto = true;
            }

        }
    }
}
