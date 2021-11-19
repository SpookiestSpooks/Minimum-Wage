using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrampolineControllerP4 : MonoBehaviour
{
    // Trampoline Control
    Rigidbody rb;

    bool xMovementRightBool;
    bool xMovementLeftBool;

    float xMovementRight;
    float xMovementLeft;
    float xMovement;

    [SerializeField] float speed = 5f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        xMovementRightBool = Input.GetKey(KeyCode.Keypad6);
        xMovementLeftBool = Input.GetKey(KeyCode.Keypad4);

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

        Vector3 movement = new Vector3(xMovement, 0f, 0f);

        rb.velocity = (movement * -1) * speed * Time.fixedDeltaTime;
    }

}
