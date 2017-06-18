using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GardenCTRL : MonoBehaviour {
    public GameObject ball;

    // Use this for initialization
    //void Start () {
    //    ball.SetActive(false);
    //}
	
	// Update is called once per frame
	public void OnClick() {
        ball.SetActive(true);
        print("keluar");
    }
}
