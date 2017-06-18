using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableButton : MonoBehaviour {

    // Use this for initialization
    public GameObject bowl;
    //Vector3 startPos;
    //Rigidbody rb;
    //void Start()
    //{
    //    ball.SetActive(false);
    // }


    // Use this for initialization
    void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "kucing")
        {
            Delay();
        }
    }

    public void Delay()
    {
        //Set interactable to false here
        
        StartCoroutine(Reactivate());
    }

    IEnumerator Reactivate()
    {
        yield return new WaitForSeconds(200);
        //set interactable to true here
    }
}
