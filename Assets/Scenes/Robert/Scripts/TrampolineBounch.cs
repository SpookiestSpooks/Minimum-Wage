using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrampolineBounch : MonoBehaviour
{


    // Explosion/Bounch Related
    [SerializeField] float force = 10f;
    [SerializeField] float radius = 10f;

    // Audio Related
    AudioSource audioSource;


    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            audioSource.Play();

            Rigidbody rb = other.gameObject.GetComponent<Rigidbody>();

             rb.AddExplosionForce(force, transform.position, radius); 
        }
    }
}
