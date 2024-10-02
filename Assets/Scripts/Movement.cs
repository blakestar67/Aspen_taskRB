using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float speed = 1f;
    public Transform pointA, pointB;
    public bool isMovingRight;


    void fixedUpdate()
    {
        Move();
    }

    public void Move()
    {
        if (isMovingRight == true)
        {
            transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
        }
        else
        {
            transform.position -= new Vector3(speed * Time.deltaTime, 0, 0);
        }
    }
}
