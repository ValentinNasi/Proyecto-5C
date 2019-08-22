using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovCamara : MonoBehaviour
{
    public float RotacionX, RotacionY;
    void Start()
    {
        
    }

    void Update()
    {
        Rotacion();
    }


    void Rotacion()
    {
        if (Input.GetKey(KeyCode.UpArrow))
            transform.Rotate(new Vector3(RotacionX, 0, 0) * Time.deltaTime);
        if (Input.GetKey(KeyCode.DownArrow))
            transform.Rotate(new Vector3(-RotacionX, 0, 0) * Time.deltaTime);
        if (Input.GetKey(KeyCode.LeftArrow))
            transform.Rotate(new Vector3(0, -RotacionY, 0) * Time.deltaTime);
        if (Input.GetKey(KeyCode.RightArrow))
            transform.Rotate(new Vector3(0, RotacionY, 0) * Time.deltaTime);


    }
}
