using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowScript : MonoBehaviour
{

    [SerializeField] GameObject newCleanerPrefab;
    [SerializeField] Transform spawnPoint;
    BoxCollider myCollider;
    bool windowIsOpen = false;
    bool spawning = true;

    Animator anim;
    [SerializeField] float windowAnimationTime;
    [SerializeField] float windowStateChange;

    void Start()
    {
        myCollider = GetComponent<BoxCollider>();
        anim = GetComponent<Animator>();
        anim.SetBool("Closed", true);
    }

    void Update()
    {
        if (windowIsOpen)
        {
            myCollider.enabled = true;
        }
        else
        {
            myCollider.enabled = false;
        }

        if (!windowIsOpen)
        {
            Invoke("OpenWindow", windowStateChange);
        }

        if (windowIsOpen)
        {
            Invoke("CloseWindow", windowStateChange);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GameObject parent = other.transform.parent.gameObject;

            Destroy(parent);

            if (spawning)
            {
                spawning = false;
                GameObject newClener = Instantiate(newCleanerPrefab, spawnPoint.position, spawnPoint.rotation);
                Invoke("ResetSpawningBool", 2f);
            }

        }
    }




    void ResetSpawningBool()
    {
        spawning = true;
    }

    void Closed()
    {
        windowIsOpen = false;

        myCollider.center = new Vector3(0.0011f, -0.0039f, 0.01f);

        anim.SetBool("Closing", false);
        anim.SetBool("Closed", true);
    }

    void OpenWindow()
    {
        anim.SetBool("Closed", false);
        anim.SetBool("Opening", true);
        
        Invoke("Open", windowAnimationTime);
    }

    void Open()
    {
        windowIsOpen = true;

        anim.SetBool("Opening", false);
        anim.SetBool("Open", true);

        myCollider.center = new Vector3(0.0011f, -0.0156f, 0.01f);
    }

    void CloseWindow()
    {
        anim.SetBool("Open", false);
        anim.SetBool("Closing", true);
        Invoke("Closed", windowAnimationTime);
    }


}
