using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrampolineVelocityStop : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            Rigidbody rb = other.GetComponent<Rigidbody>();

            rb.velocity = Vector3.zero;
            rb.angularDrag = 0f;

        }
    }

}
