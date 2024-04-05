using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    float m_speed;

    [SerializeField]
    float m_jumpForce;


    private void Update()
    {
        MoveWithTransform();
    }


    public void MoveWithTransform()
    {
        Vector3 direction = GetInputsMovement();
        Vector3 jumpDirection = GetInputsJump();

        transform.Translate(direction * m_speed * Time.deltaTime);
        transform.Translate(jumpDirection * m_jumpForce * Time.deltaTime);
    }



    public void MoveWithRigidBody()
    {
        GetInputsMovement();
    }

    private Vector3 GetInputsMovement()
    {
        Vector3 direction = Vector3.zero;


        // FORWARD - BACKWARD
        if(Input.GetKey(KeyCode.Z))
        {
            direction.z = 1;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            direction.z = -1;
        }


        // RIGHT - LEFT
        if (Input.GetKey(KeyCode.D))
        {
            direction.x = 1;
        }
        else if (Input.GetKey(KeyCode.Q))
        {
            direction.x = -1;
        }


        return direction;
    }

    private Vector3 GetInputsJump()
    {
        if( Input.GetKeyDown(KeyCode.Space)) 
        {
            return Vector3.up;
        }

        return Vector3.zero;
    }

}
