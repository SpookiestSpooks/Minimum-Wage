using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Border : MonoBehaviour
{
    public GameProgress progress;
    public GameObject scream;

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Head")
        {
            other.gameObject.transform.parent.GetComponent<PlayerScript>().respawn = true;
            
            if (other != null)
            {
                progress.respawn(other.gameObject.transform.parent.gameObject, other.gameObject.transform.parent.tag);
                Instantiate(scream);

            }
            
        }
    }
}
