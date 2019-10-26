using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuertaSiguienteNivelGym : MonoBehaviour
{
    public static bool doorKey;
    public bool open;
    public bool close;
    public bool inTrigger;
    void Start()
    {
        doorKey = false;
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

    void Update()
    {
        if (inTrigger)
        {
            if (close)
            {
                if (doorKey)
                {
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        open = true;
                        close = false;
                    }
                }
            }
            else
            {
                if (doorKey)
                {
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        open = false;
                        close = true;
                    }
                }
            }
        }

        if (open)
        {
            var newRot = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0.0f, -90.0f, 0.0f), Time.deltaTime * 200);
            transform.rotation = newRot;
        }
        else
        {
            var newRot = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0.0f, 0.0f, 0.0f), Time.deltaTime * 200);
            transform.rotation = newRot;
        }
    }

    void OnGUI()
    {
        if (inTrigger)
        {
            if (open)
            {
                GUI.Box(new Rect(0, 60, 200, 25), "Presiona la tecla E para cerrar");
            }
            else
            {
                if (doorKey)
                {
                    GUI.Box(new Rect(0, 60, 200, 25), "Presiona la tecla E para abrir");
                }
                else
                {
                    GUI.Box(new Rect(0, 60, 200, 25), "¡Necesitas una llave!");
                }
            }
        }
    }
}
