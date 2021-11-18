using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameProgress : MonoBehaviour
{
    public GameObject[] remainingDirt;

    private void Update()
    {
        remainingDirt = GameObject.FindGameObjectsWithTag("Wiper");
    }
}
