using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorKeyUltimo : MonoBehaviour
{
    public bool inTrigger;
    public GameObject corazon;
    void OnTriggerEnter(Collider other)
    {
        inTrigger = true;
    }

    void OnTriggerExit(Collider other)
    {
        inTrigger = false;
    }

    void Update()
    {

        if (inTrigger)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                PuertaSiguienteNivelUltimo.doorKey = true;
                Destroy(this.gameObject);
                corazon.SetActive(true);
                Demonio.heart = false;
            }
        }
    }

    void OnGUI()
    {
        if (inTrigger)
        {
            GUI.Box(new Rect(0, 60, 200, 25), "Presiona E Para agarrar la llave");
        }
    }
}
