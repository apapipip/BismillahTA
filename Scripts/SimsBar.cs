using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimsBar : MonoBehaviour {

    public int CatHygiene = 100;
    public int CatFood = 100;
    public int CatHealth = 100;
    int nambah = 25;
    private int CatMood =  0;

	void Start () {
        CatMood = (CatHygiene + CatFood + CatHealth) / 3;
        print("ini darah " + CatHealth);
        print("ini mood " + CatMood);
	}
	
	// Update is called once per frame
	void OnTriggerEnter () {
        //if (collision.gameObject)
        //{
        CatHealth += nambah;
        print("Your cat just got medicine for" + nambah + ", and now become" + CatHealth);
        //print("ini mood" + CatMood);
        //}
    }

}
