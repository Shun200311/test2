using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour
{
    public float Speed = 0.01f;
    public bool c_move = false;


    void Start()
    {

    }

    void Update()
    {
        Vector2 CurrentPosition = transform.position;

        if (Input.GetKey(KeyCode.W))
        {
            CurrentPosition.y += Speed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            CurrentPosition.x -= Speed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            CurrentPosition.y -= Speed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            CurrentPosition.x += Speed;
        }

        transform.position = CurrentPosition;

    }
}
