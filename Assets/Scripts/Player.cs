using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Vector3 startPos;
    [SerializeField] private float health = 5.0f;
    [Range(0.01f, 0.5f)]
    [SerializeField] private float speed = 0.1f;

    void Start()
    {
        transform.position = startPos;
    }

    private void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.LeftArrow) && transform.position.x > -GameCamera.Border)
            transform.Translate(Vector3.left * speed);
        else if(Input.GetKey(KeyCode.RightArrow) && transform.position.x > -GameCamera.Border)
            transform.Translate(Vector3.right * speed);
    }

    private void onCollisionEnter(Collision collision)
    {
        
    }
}
