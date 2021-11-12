using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Border : MonoBehaviour
{
    public GameObject scream;
    AudioSource gameAudio;

    private void Start()
    {
        gameAudio = scream.GetComponent<AudioSource>();
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "GameController")
        {
            Instantiate(scream);
        }
    }
}
