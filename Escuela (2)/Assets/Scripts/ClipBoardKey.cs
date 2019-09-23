using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClipBoardKey : MonoBehaviour
{
    public static bool inTrigger;

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
            GUI.Box(new Rect(0, 60, 200, 25), "Presiona E Para la nota");
        }
    }
}
