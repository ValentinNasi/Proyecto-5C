using System;
using UnityEngine;

namespace UnityStandardAssets.Effects
{
    public class ParticleSystemMultiplier : MonoBehaviour
    {
        // a simple script to scale the size, speed and lifetime of a particle system

        public float multiplier = 1;
        public static int activador;

        void Awake()
        {
            gameObject.SetActive(false);
        }

        void Start()
        {
            //gameObject.SetActive(false);
            /* if (gameObject.activeSelf)
             {
                 var systems = GetComponentsInChildren<ParticleSystem>();
                 foreach (ParticleSystem system in systems)
                 {
                     ParticleSystem.MainModule mainModule = system.main;
                     mainModule.startSizeMultiplier *= multiplier;
                     mainModule.startSpeedMultiplier *= multiplier;
                     mainModule.startLifetimeMultiplier *= Mathf.Lerp(multiplier, 1, 0.5f);
                     system.Clear();
                     system.Play();
                 }
             }*/
            activador = 0;
        }

        void Update()
        {
            if (activador == 1)
            {
                var systems = GetComponentsInChildren<ParticleSystem>();
                foreach (ParticleSystem system in systems)
                {
                    ParticleSystem.MainModule mainModule = system.main;
                    mainModule.startSizeMultiplier *= multiplier;
                    mainModule.startSpeedMultiplier *= multiplier;
                    mainModule.startLifetimeMultiplier *= Mathf.Lerp(multiplier, 1, 0.5f);
                    system.Clear();
                    system.Play();
                }
            }
        }

    }
}
