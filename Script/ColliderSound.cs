using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderSound : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
        AudioSource audio = GetComponent<AudioSource>();
        audio.Play();
    }
}
