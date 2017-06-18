using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateGarden : MonoBehaviour
{

    public int hyg;
    public int foo;
    public int hea;

    void OnTriggerEnter()
    {
        int nyikat = 20;
        hyg += nyikat;
        print("Your cat just got brushed for" + nyikat + ", and now become" + hyg);
    }

    void Start()
    {
        hyg = GlobalControl.Instance.CatHygiene;
        foo = GlobalControl.Instance.CatFood;
        hea = GlobalControl.Instance.CatHealth;
        print(hyg);
    }

    //Save data to global control   
    public void SavePlayer()
    {
        GlobalControl.Instance.CatHygiene = hyg;
        GlobalControl.Instance.CatFood = foo;
        GlobalControl.Instance.CatHealth = hea;
    }
}
