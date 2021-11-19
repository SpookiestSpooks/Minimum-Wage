using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowOpening : MonoBehaviour
{
    int availableWindows;
    GameObject[] windows;
    Transform[] spawnPoints;

    public int timer = 5;
    public int amountOfWindows = 1;
    bool windowStart = false;

    bool windowOpen;

    void Start()
    {
        availableWindows = gameObject.GetComponent<WindowManager>().windowCount;
        windows = GameObject.FindGameObjectsWithTag("Window");
        spawnPoints = gameObject.GetComponent<GameProgress>().respawnLocation;
    }

    private void Update()
    {
        if (!windowStart)
        {
            for (int i = 0; i < amountOfWindows; i++)
            {
                opening();
            }
            windowStart = true;
            Invoke("resetTimer", 15);
        }
        
    }

    void opening()
    {
        
        int spawnRandom = Random.Range(0,3);
        int windowRandom = Random.Range(0, windows.Length - 1);
        windows[windowRandom].GetComponentInChildren<WindowScript>().spawnPoint = spawnPoints[spawnRandom];
        windows[windowRandom].GetComponentInChildren<WindowScript>().openWindow();
    }

    void resetTimer()
    {
        windowStart = false;
    }

}
