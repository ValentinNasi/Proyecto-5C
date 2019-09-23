using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoPatallaGym : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void OnGUI()
    {
        if (Input.GetKey(KeyCode.T))
        {

            GUI.Box(new Rect(0, 0, 400, 25), "Convierte un gol, toma tu nota, y vuelve al aula");
        }
    }
}
