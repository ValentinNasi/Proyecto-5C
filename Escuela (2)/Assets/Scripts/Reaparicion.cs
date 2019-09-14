using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reaparicion : MonoBehaviour
{
   // public GameObject puntoreaparicion;
    void Start()
    {
        
    }

    void Update()
    {
    }

   void OnTriggerEnter(Collider other)
    {
        
        int vida = 1;
        if(other.gameObject.tag == "NPC")
        {
            Debug.Log("Se tocan");
            vida = 0;
            if (vida == 0)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
            else
                vida = 1;
            
        }
    }
    
    /*private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.tag == "NPC")
        {
            Debug.Log("Se tocan");
            this.gameObject.transform.position = puntoreaparicion.transform.position;
        }
    }*/
   
}
