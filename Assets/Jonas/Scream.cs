using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scream : MonoBehaviour
{

    AudioSource audioObject;
    private void Start()
    {
        audioObject = gameObject.GetComponent<AudioSource>();
        audioObject.pitch = Random.Range(0.8f, 1.25f);
    }

    void Update()
    {
        if (gameObject.GetComponent<AudioSource>().isPlaying == false)
        {
            Destroy(gameObject);
        }
    }
}
