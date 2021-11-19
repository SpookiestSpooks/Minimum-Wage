using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrampolineController : MonoBehaviour
{
    // Trampoline Control
    Rigidbody rb;

    bool xMovementRightBool;
    bool xMovementLeftBool;

    float xMovementRight;
    float xMovementLeft;
    float xMovement;

    [SerializeField] float speed = 5f;

    Vector3 movement;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {


        #region // Horizontal Movement
        xMovementRightBool = Input.GetKey(KeyCode.D);
        xMovementLeftBool = Input.GetKey(KeyCode.A);

        if (xMovementRightBool)
        {
            xMovementRight = 1f;
        }
        else
        {
            xMovementRight = 0f;
        }

        if (xMovementLeftBool)
        {
            xMovementLeft = -1f;
        }
        else
        {
            xMovementLeft = 0f;
        }

        xMovement = xMovementRight + xMovementLeft;

        #endregion


        movement = new Vector3(xMovement, 0f, 0f);

        rb.velocity = (movement * -1) * speed * Time.fixedDeltaTime;


    }
}