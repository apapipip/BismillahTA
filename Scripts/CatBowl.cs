using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatBowl : MonoBehaviour {
    
    public GameObject bowl;
    private Vector3 initialPosition;
    private Quaternion initialRotation;

    void Start()
    {
        initialPosition = transform.position;
        initialRotation = transform.rotation;
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "kucing")
        {
            bowl.SetActive(false);
            print("KENA MANGKOK");
        }
        Invoke("munculmangkok", 7);
    }

    void munculmangkok()
    {
        transform.position = initialPosition;
        transform.rotation = initialRotation;
        this.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionZ;
        this.GetComponent<Rigidbody>().freezeRotation = true;

        bowl.SetActive(true);
        this.GetComponent<Rigidbody>().freezeRotation = false;
        this.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
    }
}
