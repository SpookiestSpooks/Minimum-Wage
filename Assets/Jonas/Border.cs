using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Border : MonoBehaviour
{
    public GameObject scream;

    public GameProgress progress;

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            Instantiate(scream);
            other.gameObject.transform.parent.GetComponent<PlayerScript>().respawn = true;
            
            if (progress.isAlive)
            {
                progress.isAlive = false;
                progress.respawn(other.gameObject);
            }
            
        }
    }
}
