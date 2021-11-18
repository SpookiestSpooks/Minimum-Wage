using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Border : MonoBehaviour
{
    public GameObject scream;

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            Instantiate(scream);
        }
    }
}
