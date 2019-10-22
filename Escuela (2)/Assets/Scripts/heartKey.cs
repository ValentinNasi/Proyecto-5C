using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heartKey : MonoBehaviour
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
            GUI.Box(new Rect(0, 60, 300, 25), "Presiona E agarrar el corazon");
            if (Input.GetKeyDown(KeyCode.E))
            {
                Destroy(this.gameObject);
                Demonio.heart = true;
            }
              
        }
    }
}
