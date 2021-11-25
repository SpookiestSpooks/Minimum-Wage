using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crashes : MonoBehaviour
{

    AudioSource audioObject;
    public List<AudioClip> crashes = new List<AudioClip>();
    private void Start()
    {
        audioObject = gameObject.GetComponent<AudioSource>();
        StartCoroutine(playSound());
    }

    void Update()
    {
        if (gameObject.GetComponent<AudioSource>().isPlaying == false)
        {
            Destroy(gameObject);
        }
    }
    
    IEnumerator playSound()
    {
        for (int i = 0; i < 3; i++)
        {
            audioObject.PlayOneShot(crashes[Random.Range(0,crashes.Count)], 1f);
            yield return new WaitForSeconds(0.2f);
        }
    }
}
