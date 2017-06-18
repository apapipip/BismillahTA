using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AnimationSoundTriggerGarden: MonoBehaviour
{
    //public AudioSource ani;
    Animator anim;
    AudioSource source;
    public GameObject emotelove;

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
        print(CatHealth);
        print(CatFood);
        print(CatHygiene);
        print(CatFun);

        emotelove.SetActive(false);

        InvokeRepeating("minuspersecond", 5, 5);
    }

    void OnTriggerEnter(Collider collider)
    {

        if (collider.tag == "bowl")
        {
            anim.SetInteger("RandomIdleID", 12);
            
            int mandi = 5;
            int sehat = 7;
            int laper = 10;
            int senang = 5;

            CatHygiene -= mandi;
            CatHealth += sehat;
            CatFood += laper;
            CatFun += senang;

            SavePlayer();
            print("-----");
            print(CatHealth);
            print(CatFood);
            print(CatHygiene);
            print(CatFun);

            emotelove.SetActive(true);

            Invoke("resetanim", 10);
        }

        if (collider.tag == "ball")
        {
            anim.SetInteger("RandomIdleID", 11);
            source.Play();

            int mandi = 5;
            int sehat = 3;
            int laper = 5;
            int senang = 7;

            CatHygiene -= mandi;
            CatHealth += sehat;
            CatFood -= laper;
            CatFun += senang;

            SavePlayer();
            print("-----");
            //print("main");
            print(CatHealth);
            print(CatFood);
            print(CatHygiene);
            print(CatFun);

            emotelove.SetActive(true);

            Invoke("resetanim", 5);
        }


        if (collider.tag == "hand")
        {
            anim.SetInteger("RandomIdleID", 10);
            source.Play();

            int sehat = 3;
            int senang = 5;

            CatHealth += sehat;
            CatFun += senang;
        }

        //resetanim();
    }

    void minuspersecond()
    {
        int minus = 1;
        CatHealth -= minus;
        CatFood -= minus;
        CatHygiene -= minus;
        CatFun -= minus;

        SavePlayer();
        print("-----");
        print(CatHealth);
        print(CatFood);
        print(CatHygiene);
        print(CatFun);
    }

    void resetanim()
    {
        anim.SetInteger("RandomIdleID", 0);
        emotelove.SetActive(false);
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

    public void SavePlayer()
    {
        GlobalControl.Instance.CatHygiene = CatHygiene;
        GlobalControl.Instance.CatFood = CatFood;
        GlobalControl.Instance.CatHealth = CatHealth;
        GlobalControl.Instance.CatFun = CatFun;
    }

}