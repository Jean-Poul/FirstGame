using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playAudioOnCollision : MonoBehaviour
{
    public AudioSource indianaTheme;

    void Start()
    {
        indianaTheme = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider collide)
    {
        if (collide.gameObject.name == "soundcol")
        {
            indianaTheme.Play();
        }

    }

}
