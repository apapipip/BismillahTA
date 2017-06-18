using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BallDisappear : MonoBehaviour {

    public GameObject ball;
    public GameObject Cube;
    private Vector3 initialPosition;
    private Quaternion initialRotation;
    
    void Start()
    {
        initialPosition = transform.position;
        initialRotation = transform.rotation;
        Cube.SetActive(true);
    }

    
    void OnTriggerEnter (Collider collider) {
        if (collider.tag == "kucing")
       {
            ball.SetActive(false);
            print("KENA BOLA");
       }
       Invoke("munculbola", 5);
    }

    void munculbola()
    {
        transform.position = initialPosition;
        transform.rotation = initialRotation;
        this.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionZ;
        this.GetComponent<Rigidbody>().freezeRotation = true;
        
        ball.SetActive(true);
        this.GetComponent<Rigidbody>().freezeRotation = false;
        this.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
    }
 
}
