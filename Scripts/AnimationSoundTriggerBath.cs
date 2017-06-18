using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AnimationSoundTriggerBath: MonoBehaviour
{
    //initiate variabel animasi dan suara
    Animator anim;
    AudioSource source;

    //initiate variabel Sims Bar
    public int CatHygiene;
    public int CatFood;
    public int CatHealth;
    public int CatFun;

    void Start()
    {
        //Animasi dan suara
        anim = GetComponent<Animator>();
        source = GetComponent<AudioSource>();

        //Ambil data Sims Bar
        CatHygiene = GlobalControl.Instance.CatHygiene;
        CatFood = GlobalControl.Instance.CatFood;
        CatHealth = GlobalControl.Instance.CatHealth;
        CatFun = GlobalControl.Instance.CatFun;

        //Mengurangi status tiap detik
        InvokeRepeating("minuspersecond", 5, 5);

        //
    }

    void OnTriggerEnter(Collider collider)
    {   
        //collide dengan brush
        if (collider.tag == "brush")
        {
            anim.SetInteger("RandomIdleID", 11);
            source.Play();

            int mandi = 10;
            int sehat = 3;
            int laper = 3;
            int senang = 5;

            CatHygiene += mandi;
            CatHealth += sehat;
            CatFood -= laper;
            CatFun += senang;

            SavePlayer();
            print("hasil sikat");
            print(CatHealth);
            print(CatFood);
            print(CatHygiene);
            print(CatFun);

            Invoke("resetanim", 2);
            
        }

        //collide dengan tangan
        if (collider.tag == "hand")
        {
            anim.SetInteger("RandomIdleID", 10);
            source.Play();

            int sehat = 3;
            int senang = 5;

            CatHealth += sehat;
            CatFun += senang;

            //print("health = " + hea + "hygiene = " + hyg + "hunger = " + foo + "fun = " + fun);
            print("kena tangan");
        }
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

    void resetanim()
    {
        anim.SetInteger("RandomIdleID", 0);
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

    void cekstatus()
    {
        if(CatFood <= 0 || CatFun <= 0 || CatHealth <= 0 || CatHygiene <= 0)
        {
            Application.LoadLevel("gameover");
        }
    }

    //fungsi update Sims Bar
    public void SavePlayer()
    {
        GlobalControl.Instance.CatHygiene = CatHygiene;
        GlobalControl.Instance.CatFood = CatFood;
        GlobalControl.Instance.CatHealth = CatHealth;
        GlobalControl.Instance.CatFun = CatFun;
    }
}