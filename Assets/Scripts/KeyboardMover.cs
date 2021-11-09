using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * This component moves its object when the player clicks the arrow keys.
 */
public class KeyboardMover: MonoBehaviour {
    [Tooltip("Speed of movement, in meters per second")]
    [SerializeField] float speed = 1f;
    [SerializeField] protected KeyCode moveUp;
    [SerializeField] protected KeyCode moveDown;
    [SerializeField] protected KeyCode moveLeft;
    [SerializeField] protected KeyCode moveRight;


    void Update() {
        if (Input.GetKey(moveUp))
        {
            transform.position += new Vector3(0, Time.deltaTime*speed, 0);
        }
        if (Input.GetKey(moveDown))
        {
            transform.position += new Vector3(0, -Time.deltaTime*speed, 0);
        }
        if (Input.GetKey(moveRight))
        {
            transform.position += new Vector3(Time.deltaTime*speed, 0, 0);
        }
        if (Input.GetKey(moveLeft))
        {
            transform.position += new Vector3(-Time.deltaTime*speed, 0, 0);
        }
 
    }
    // public void SetSpeed(float newSpeed) {
    //     this.speed = newSpeed;
    // }
    //
    // public float getSpeed()
    // {
    //    return this.speed;
    // }
}
