using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float speed = 1f;
    public bool isMovingRight;

    public float movementTimer = 0;
    public float timerSpeed = 1;
    public float switchDirection = 5;

    private void Start()
    {
        isMovingRight = true;
    }

    void Update()
    {
        Move();
        Timer();
    }

    public void Move()
    {
        if (isMovingRight == true)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
    }


    public void Timer()
    {
        movementTimer += timerSpeed * Time.deltaTime;
        if (movementTimer >= switchDirection)
        {
            movementTimer = 0;
            if (isMovingRight == true)
            {
                isMovingRight = false;
            }
            else
            {
                isMovingRight = true;
            }
        }
    }
}
