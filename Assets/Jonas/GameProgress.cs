using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameProgress : MonoBehaviour
{
    public GameObject[] remainingDirt;
    public Transform[] respawnLocation;
    public GameObject Player1, Player2, Player3, Player4; //prefabs
    

    private void Update()
    {
        remainingDirt = GameObject.FindGameObjectsWithTag("Wiper");

        if (Input.GetButton("Cancel"))
        {
            Application.Quit();
        }
    }

    public void respawn(GameObject player, string playerTag)
    {    
        Destroy(player);
        StartCoroutine(waitRespawn(playerTag));
    }

    IEnumerator waitRespawn(string playerTag)
    {
        yield return new WaitForSeconds(2);
        int random = Random.Range(0,3);
        if (playerTag == "Player")
        {
            GameObject spawnedPlayer = Instantiate(Player1, respawnLocation[random].position, respawnLocation[random].rotation);
        }
        if (playerTag == "Player2")
        {
            GameObject spawnedPlayer = Instantiate(Player2, respawnLocation[random].position, respawnLocation[random].rotation);
        }
        if (playerTag == "Player3")
        {
            GameObject spawnedPlayer = Instantiate(Player3, respawnLocation[random].position, respawnLocation[random].rotation);
        }
        if (playerTag == "Player4")
        {
            GameObject spawnedPlayer = Instantiate(Player4, respawnLocation[random].position, respawnLocation[random].rotation);
        }
    }
}
