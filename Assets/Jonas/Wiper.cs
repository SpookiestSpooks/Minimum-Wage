using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wiper : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Wiper")
        {
            Destroy(other.gameObject);
        }
    }
}
