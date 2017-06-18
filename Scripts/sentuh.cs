using UnityEngine;
using System.Collections;

public class sentuh : MonoBehaviour
{
    Animator ani;
    AudioClip sound;

    void Start()
    {
        ani.enabled = false;
    }

    void OnTriggerEnter()
    {
        AudioSource.PlayClipAtPoint(sound, transform.position);
        ani.enabled = true;
        Destroy(gameObject);
    }
}