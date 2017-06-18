using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class AnimationSoundTriggerLiving : MonoBehaviour
{
    //public AudioSource ani;
    Animator anim;
    AudioSource source;

    public int CatHygiene;
    public int CatFood;
    public int CatHealth;
    public int CatFun;

    void Start()
    {
        anim = GetComponent<Animator>();
        source = GetComponent<AudioSource>();

        CatHygiene = GlobalControl.Instance.CatHygiene;
        CatFood = GlobalControl.Instance.CatFood;
        CatHealth = GlobalControl.Instance.CatHealth;
        CatFun = GlobalControl.Instance.CatFun;

        print("start");
        print(CatHygiene);
        print(CatFood);
        print(CatHealth);
        print(CatFun);

        InvokeRepeating("minuspersecond", 5, 5);
    }

    void OnTriggerEnter(Collider collider)
    {

        if (collider.tag == "hand2")
        {
            anim.SetInteger("RandomIdleID", 10);
            source.Play();

            int sehat = 3;
            int senang = 5;

            CatHealth += sehat;
            CatFun += senang;
        }

        else if (collider.tag == "suntikan")
        {

            anim.SetInteger("RandomIdleID", 11);
            source.Play();
            //int mandi = 5;
            int sehat = 7;
            int laper = 5;
            int senang = 3;

            //hyg -= mandi;
            CatHealth += sehat;
            CatFood -= laper;
            CatFun -= senang;

            print("disuntik");
            print(CatHygiene);
            print(CatFood);
            print(CatHealth);
            print(CatFun);

            Invoke("resetanim", 2);
        }
    }

    void resetanim()
    {
        anim.SetInteger("RandomIdleID", 0);
    }


    void minuspersecond()
    {
        int minus = 1;
        CatHealth -= minus;
        CatFood -= minus;
        CatFun -= minus;
        CatHygiene -= minus;

        SavePlayer();
        print("--------------------");
        print(CatHealth);
        print(CatFood);
        print(CatHygiene);
        print(CatFun);
    }

    void Update()
    {
        if (CatHealth > 100)
        {
            CatHealth = 100;
        }
        else if (CatFood > 100)
        {
            CatFood = 100;
        }
        else if (CatFun > 100)
        {
            CatFun = 100;
        }
        else if (CatHygiene > 100)
        {
            CatHygiene = 100;
        }
    }

    void SavePlayer()
    {
        GlobalControl.Instance.CatHygiene = CatHygiene;
        GlobalControl.Instance.CatFood = CatFood;
        GlobalControl.Instance.CatHealth = CatHealth;
        GlobalControl.Instance.CatFun = CatFun;
    }
}

    
    
   
