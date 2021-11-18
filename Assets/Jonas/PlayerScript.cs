using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    GameObject wiper;
    public GameObject player;
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
            //StartCoroutine(waitHere());
        }
    }

    /*IEnumerator waitHere()
    {
        yield return new WaitForSeconds(respawnTimer);
        GameObject spawnedPlayer = Instantiate(player, Vector3.zero, respawnLocation.rotation);
        spawnedPlayer.transform.position = respawnLocation.position;
        print(true);
        Destroy(gameObject);
    }*/

}
