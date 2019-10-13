using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaAnimacion : MonoBehaviour
{
    public float VelocidadMovimiento = 5.0f;
     public float VelocidadRotacion = 200.0f;
    private Animator anim;
    public float x, y;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //x = Input.GetAxis("Horizontal");
        //y = Input.GetAxis("Vertical");
    
        
    }

}
