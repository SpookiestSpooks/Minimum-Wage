using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameProgress : MonoBehaviour
{
    public GameObject[] remainingDirt;
    public Transform respawnLocation;
    public GameObject Player;
    public bool isAlive = true;

    private void Update()
    {
        remainingDirt = GameObject.FindGameObjectsWithTag("Wiper");
    }

    public void respawn(GameObject player)
    {
        Destroy(player);
        StartCoroutine(waitRespawn());
    }

    IEnumerator waitRespawn()
    {
        yield return new WaitForSeconds(2);

        GameObject spawnedPlayer = Instantiate(Player, Vector3.zero, respawnLocation.rotation);
        spawnedPlayer.transform.position = respawnLocation.position;
        isAlive = true;
        print(true);
    }
}
