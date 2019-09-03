using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoPantalla : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void OnGUI()
    {
        

        if(Input.GetKey(KeyCode.T))
        {
            
            GUI.Box(new Rect(0, 0, 400, 25), "Busca la llave que te permita abrir el aula 1111");
        }
    }
}
