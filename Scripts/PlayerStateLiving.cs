using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateLiving : MonoBehaviour
{

    public int hyg;
    public int foo;
    public int hea;

    void OnTriggerEnter()
    {
        int sehat = 15;
        int lapar = 5;
        int mandi = 1;

        hyg -= mandi;
        foo -= lapar;
        hea += sehat;

        print("health " + hea + "hygiene " + hyg + "hunger " + foo);
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
