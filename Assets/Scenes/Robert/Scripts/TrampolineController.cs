using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrampolineController : MonoBehaviour
{
    // Trampoline Control
    Rigidbody rb;


    float xMovement;
    [SerializeField] float speed = 5f;

    void Start()
    {

        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        xMovement = Input.GetAxis("Horizontal");

        Vector3 movement = new Vector3(xMovement, 0f, 0f);

        rb.velocity = (movement) * speed * Time.fixedDeltaTime;
    }

}
