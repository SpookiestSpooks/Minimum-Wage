using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour
{

    CharacterController charController1;

    bool xMovementRightBool;
    bool xMovementLeftBool;

    float xMovementRight;
    float xMovementLeft;
    float xMovement;

    [SerializeField] float moveSpeed = 5f;

    void Start()
    {
        charController1 = GetComponent<CharacterController>();
    }


    void Update()
    {
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

        charController1.Move(new Vector3(xMovement * moveSpeed, 0f, 0f) * Time.deltaTime);
    }
}
