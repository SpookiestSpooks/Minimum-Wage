using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scream : MonoBehaviour
{
    void Update()
    {
        if (gameObject.GetComponent<AudioSource>().isPlaying == false)
        {
            Destroy(gameObject);
        }
    }
}
