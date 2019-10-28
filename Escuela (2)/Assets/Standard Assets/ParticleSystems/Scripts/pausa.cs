using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pausaManager : MonoBehaviour
{
    
    Canvas canvas;
    void Start()
    {
        canvas = GetComponent<Canvas>();
        canvas.enabled = false;
    }

   
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Pause();
        }    
    }
    public void Pause()
    {
        canvas.enabled = !canvas.enabled;
        Time.timeScale = Time.timeScale == 0 ? 1 : 0;
    }
    public void salir()
    {
        Application.Quit();
        Debug.Log("se salio xd");
    }
}
