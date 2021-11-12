using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrampolineBounch : MonoBehaviour
{


    // Explosion/Bounch Related
    [SerializeField] float force = 10f;
    [SerializeField] float radius = 10f;

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Hello");

        if (other.gameObject.CompareTag("Player"))
        {
            Rigidbody rb = other.gameObject.GetComponent<Rigidbody>();

            if(rb != null)
            {
                Debug.Log("GOT A BODY");
                rb.AddExplosionForce(force, transform.position, radius);
            }
            
        }

    }
}
