using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClipBoardKey : MonoBehaviour
{
    public static bool inTrigger;

    void Start()
    {
        PuertaSiguienteNivelGym.doorKey = false;
        inTrigger = false;
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
            if (PuertaSiguienteNivelGym.doorKey == false)
            {
                GUI.Box(new Rect(0, 60, 200, 25), "Presiona E Para la nota");
                if (inTrigger)
                {
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        Destroy(this.gameObject);
                        PuertaSiguienteNivelGym.doorKey = true;
                    }
                }

            }
        }
    }
}
