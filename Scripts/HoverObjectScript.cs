using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverObjectScript : MonoBehaviour {

	void OnTriggerEnter()
    {
        gameObject.GetComponent<Renderer>().material.color = Color.blue;
    }

    void OnTriggerExit()
    {
        gameObject.GetComponent<Renderer>().material.color = Color.red;
    }
}
