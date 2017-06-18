using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestAnimTrigger : MonoBehaviour {

    Animator animasi;
    //AudioSource suara;
    // Use this for initialization
    void Start() {
        animasi = this.GetComponent<Animator>();
    }

    void OnTriggerEnter () {
        animasi.enabled = true;
        Debug.Log("A");
        
   

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
 