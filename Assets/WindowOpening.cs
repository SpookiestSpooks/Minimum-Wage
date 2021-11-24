using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowOpening : MonoBehaviour
{
    int availableWindows;
    public List<GameObject> windows = new List<GameObject>();
    Transform[] spawnPoints;

    public int timer = 5;
    public int amountOfWindows = 1;
    bool windowStart = false;

    public bool enableOpening = false;

    void Start()
    {
        spawnPoints = gameObject.GetComponent<GameProgress>().respawnLocation;
    }

    private void Update()
    {
        if (enableOpening)
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
        else
        {
            resetTimer();
        }
    }

    public void setupWindows()
    {
        availableWindows = gameObject.GetComponent<WindowManager>().windowCount;
        windows = gameObject.GetComponent<WindowManager>().windows;
    }

    void opening()
    {
        int spawnRandom = Random.Range(0,3);
        int windowRandom = Random.Range(0, windows.Count - 1);
        windows[windowRandom].GetComponentInChildren<WindowScript>().spawnPoint = spawnPoints[spawnRandom];
        windows[windowRandom].GetComponentInChildren<WindowScript>().openWindow();
    }

    void resetTimer()
    {
        windowStart = false;
    }

}
