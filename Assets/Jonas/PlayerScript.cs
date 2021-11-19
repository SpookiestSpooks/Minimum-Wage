using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    GameObject wiper;
    GameProgress progress;

    public GameObject player;
    public bool isAlive;

    public bool respawn = false;
    public float respawnTimer = 2;

    void Start()
    {
        wiper = gameObject.transform.GetChild(1).gameObject;
        progress = GameObject.Find("GameProgress").GetComponent<GameProgress>();
    }

    /*private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bounds")
        {
            progress.respawn(gameObject, gameObject.tag);
        }
    }*/
}
