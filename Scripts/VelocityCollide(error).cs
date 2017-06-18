using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VelocityCollide : MonoBehaviour {

        void OnTriggerEnter(Collision collision)
        {
            AudioSource source = GetComponent<AudioSource>();
            //source.Play();
            if (collision.relativeVelocity.magnitude > 1)
                source.Play();
        }
        
    }

