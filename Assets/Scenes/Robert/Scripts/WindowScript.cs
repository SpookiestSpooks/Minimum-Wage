using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowScript : MonoBehaviour
{
    GameProgress progress;

    [SerializeField] GameObject newCleanerPrefab;
    public Transform spawnPoint;
    BoxCollider myCollider;
    bool windowIsOpen = false;
    bool dead = false;

    Animator anim;
    [SerializeField] float windowAnimationTime;
    [SerializeField] float windowStateChange;

    void Start()
    {
        myCollider = GetComponent<BoxCollider>();
        anim = GetComponent<Animator>();
        anim.SetBool("Closed", true);

        progress = GameObject.Find("GameProgress").GetComponent<GameProgress>();
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

        if (windowIsOpen)
        {
            if (!dead)
            {
                Invoke("CloseWindow", windowStateChange);
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Torso")
        {
            other.gameObject.transform.parent.GetComponent<PlayerScript>().respawn = true;

            if (other != null)
            {
                progress.respawn(other.gameObject.transform.parent.gameObject, other.gameObject.transform.parent.tag, true);
                CloseWindow();
                dead = true;
            }

        }
    }


    public void openWindow()
    {
        Invoke("OpenWindow", windowStateChange);
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
        dead = false;
    }


}
