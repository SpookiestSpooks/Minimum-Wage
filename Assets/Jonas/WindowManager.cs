using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowManager : MonoBehaviour
{

    GameObject[] windows;
    public int windowCount;
    public int dirtyWindows = 10;

    public GameObject dirtGroup;
    List<int> dirtiedList = new List<int>();

    // Start is called before the first frame update
    public void Setup()
    {
        getWindows();
        generateDirt();
    }

    public void getWindows()
    {
        windows = GameObject.FindGameObjectsWithTag("Window");
        windowCount = windows.Length;
    }

    public void generateDirt()
    {
        for (int i = 0; i < dirtyWindows; i++)
        {
            int random = Random.Range(0, windowCount - 1);
            if (dirtiedList.Contains(random))
            {
                i--;
            }
            else
            {
                Instantiate(dirtGroup, windows[random].transform.position, windows[random].transform.rotation);
                dirtiedList.Add(random);
            }
        }
    }

}
