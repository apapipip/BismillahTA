using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateBath : MonoBehaviour
{

    public int hyg;
    public int foo;
    public int hea;

    void OnTriggerEnter()
    {
        int mandi = 10;
        int sehat = 3;
        int laper = 1;

        hyg += mandi;
        hea += sehat;
        foo -= laper;

        print( "health " + hea + "hygiene " + hyg + "hunger " + foo);
    }

    void Start()
    {
        hyg = GlobalControl.Instance.CatHygiene;
        foo = GlobalControl.Instance.CatFood;
        hea = GlobalControl.Instance.CatHealth;
    }

    //Save data to global control   
    public void SavePlayer()
    {
        GlobalControl.Instance.CatHygiene = hyg;
        GlobalControl.Instance.CatFood = foo;
        GlobalControl.Instance.CatHealth = hea;
    }
}
