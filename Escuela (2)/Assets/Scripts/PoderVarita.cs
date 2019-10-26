using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoderVarita : MonoBehaviour
{
    public static bool varita;
    public static bool inTrigger;
    public GameObject NPC1;
    public GameObject NPC2;
    public GameObject NPC3;
    public GameObject NPC4;
    public GameObject explosion1;
    public GameObject explosion2;
    public GameObject explosion3;
    public GameObject explosion4;

    public static bool todolisto = false;
    void Start()
    {
        varita = false;
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ActivacionVarita")
        {
            if (varita)
            {
                inTrigger = true;
            }
        }
    }
    void OnTriggerExit(Collider other)
    {
        inTrigger = false;
    }

    void OnGUI()
    {
        
        if (inTrigger)
        {
            GUI.Box(new Rect(0, 60, 300, 25), "Presiona X para destruir");
            if (Input.GetKeyDown(KeyCode.X))
            {
                Destroy(NPC1);
                Destroy(NPC2);
                Destroy(NPC3);
                Destroy(NPC4);
                explosion1.SetActive(true);
                explosion2.SetActive(true);
                explosion3.SetActive(true);
                explosion4.SetActive(true);
                UnityStandardAssets.Effects.ParticleSystemMultiplier.activador = 1;
                todolisto = true;
            }

        }
    }
}
