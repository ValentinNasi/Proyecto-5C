using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovWachin : MonoBehaviour {
    public float Velocidad, RotacionX, RotacionY;

    

	void Start () {
		
	}
	
	void FixedUpdate () {
        Movimiento();
	}

    void Movimiento()
    {
        Rigidbody rigidbody = GetComponent<Rigidbody>();



        if (Input.GetKey(KeyCode.W))
        {
            rigidbody.MovePosition(rigidbody.position + (Vector3.forward * Velocidad * Time.deltaTime));
        }

        if (Input.GetKey(KeyCode.S))
        {
            rigidbody.MovePosition(rigidbody.position + (Vector3.back * Velocidad * Time.deltaTime));
        }

        if (Input.GetKey(KeyCode.A))
        {
            rigidbody.MovePosition(rigidbody.position + (Vector3.left * Velocidad * Time.deltaTime));
        }

        if (Input.GetKey(KeyCode.D))
        {
            rigidbody.MovePosition(rigidbody.position + (Vector3.right * Velocidad * Time.deltaTime));
        }
    }
}
