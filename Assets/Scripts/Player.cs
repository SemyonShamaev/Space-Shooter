using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Vector3 startPos;
    [SerializeField] private float health = 5.0f;
    [SerializeField] private Joystick joystick;
    [Range(0.01f, 0.5f)]
    [SerializeField] private float speed = 0.1f;

    void Start()
    {
        transform.position = startPos;
    }

    void Update()
    {

    }
    void FixedUpdate()
    {
        /*if(joystick.Horizontal() > 0)
            transform.Translate(Vector3.back * speed);
        if(joystick.Horizontal() < 0)
            transform.Translate(Vector3.forward * speed);
        if(joystick.Vertical() > 0)
            transform.Translate(Vector3.right * speed);
        if(joystick.Vertical() < 0)
            transform.Translate(Vector3.left * speed);*/

        if(Input.GetKey(KeyCode.W) && transform.position.y < GameCamera.BorderY) 
            transform.Translate(Vector3.right * speed);
        if(Input.GetKey(KeyCode.A) && transform.position.x > - GameCamera.BorderX) 
            transform.Translate(Vector3.forward * speed);
        if(Input.GetKey(KeyCode.S) && transform.position.y > - GameCamera.BorderY) 
            transform.Translate(Vector3.left * speed);
        if(Input.GetKey(KeyCode.D) && transform.position.x < GameCamera.BorderX) 
            transform.Translate(Vector3.back * speed);
    }

    private void onCollisionEnter(Collision collision)
    {
        
    }
}
