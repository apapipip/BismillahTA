using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ResetPosition : MonoBehaviour {

	Vector3 startPos;
	// Use this for initialization
	void Start () {
		startPos = transform.position;
	}
	
	// Update is called once per frame
	void OnTriggerExit () {
        Invoke("comeback", 1);
    }

    void comeback()
    {
        transform.position = startPos;
    }
}
	