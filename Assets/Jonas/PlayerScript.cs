using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    GameObject wiper;
    Transform respawnLocation;

    public bool respawn = false;
    public float respawnTimer = 2;

    void Start()
    {
        wiper = gameObject.transform.GetChild(1).gameObject;
        respawnLocation = GameObject.Find("RespawnLocation").transform;
    }

    void FixedUpdate()
    {
        if (respawn)
        {
            StartCoroutine(waitHere());
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Bounds")
        {
            respawn = true;
        }
    }

    IEnumerator waitHere()
    {
        yield return new WaitForSeconds(respawnTimer);
        gameObject.transform.position = respawnLocation.position;
        gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
        respawn = false;
    }

}
