using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snake : MonoBehaviour
{

    // variable to keep track of movement
    private Vector2 _direction = Vector2.right;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            _direction = Vector2.up;
        } else if (Input.GetKeyDown(KeyCode.S))
        {
            _direction = Vector2.down;
        } else if (Input.GetKeyDown(KeyCode.A))
        {
            _direction = Vector2.left;
        } else if (Input.GetKeyDown(KeyCode.D))
        {
            _direction = Vector2.right;
        }
    }

    // Fixed Framerate for implementing physics
    private void FixedUpdate()
    {
        this.transform.position = new Vector3(
            Mathf.Round(this.transform.position.x) + _direction.x,
            Mathf.Round(this.transform.position.y) + _direction.y,
            0.0f
        );
    }
}
