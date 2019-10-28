using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class salir : MonoBehaviour
{
    bool active;
    Canvas canvas;
    
    
    void Start()
    {
        canvas = GetComponent<Canvas>();
        canvas.enabled = false;
    }

   
    void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            active = !active;
            canvas.enabled = active;
            Time.timeScale = (active) ? 0 : 1f;
        }

    }
    public void volvermenu()
    {
        Application.Quit();
        Debug.Log("se salio xd");
    }
}



