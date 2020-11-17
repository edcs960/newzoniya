using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kite : MonoBehaviour
{
    Vector3 position;
    public float Speed = 1;

    void Start()
    {
        position = transform.position;
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            position.x -= Speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            position.x += Speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            position.y += Speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            position.y -= Speed * Time.deltaTime;
        }

        transform.position = position;
    }
}