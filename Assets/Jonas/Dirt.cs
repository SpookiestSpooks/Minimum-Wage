using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dirt : MonoBehaviour
{
    GameObject graphic;
    private void Start()
    {
        graphic = gameObject.transform.GetChild(0).gameObject;
        float rotation = Random.Range(-80, 80);
        Vector3 randomRotation = new Vector3(graphic.transform.rotation.x, graphic.transform.rotation.y, rotation);
        graphic.transform.rotation = Quaternion.Euler(randomRotation);
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Wiper")
        {
            Destroy(gameObject);
        }
    }

}
