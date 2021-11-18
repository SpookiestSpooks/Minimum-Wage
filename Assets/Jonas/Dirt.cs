using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dirt : MonoBehaviour
{
    GameObject graphic;
    Color[] dirts = { Color.gray, Color.white, new Color(165, 42, 42) };
    private void Start()
    {
        graphic = gameObject.transform.GetChild(1).gameObject;
        float rotation = Random.Range(-80, 80);
        Vector3 randomRotation = new Vector3(graphic.transform.rotation.x, graphic.transform.rotation.y, rotation);
        graphic.transform.rotation = Quaternion.Euler(randomRotation);

        graphic.GetComponent<SpriteRenderer>().color = dirts[Random.Range(0, dirts.Length)];
        
    }
}
