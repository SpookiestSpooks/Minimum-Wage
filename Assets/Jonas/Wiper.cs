using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wiper : MonoBehaviour
{
    [Range(1,4)]
    public int playerNumber = 1;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Wiper")
        {
            Destroy(other.gameObject);
            GameObject.Find("GameProgress").GetComponent<GameProgress>().getPoints(playerNumber);
        }
    }
}
