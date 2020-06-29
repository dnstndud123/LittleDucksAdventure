﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sencor : MonoBehaviour
{
    public float _speedX;
    public float _speedY;
    bool right = true;
    bool up = true;
    public Collider2D collision;

    public float desPointX;
    public float oriPointX;
    public float desPointY;
    public float oriPointY;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        OnTriggerEnter2D(collision);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "player")
        {
            collision.gameObject.transform.parent = transform;
            Vector2 pos = transform.localPosition;

            float moveX = Time.deltaTime * _speedX;
            float moveY = Time.deltaTime * _speedY;
            if (right)
            {
                moveX = moveX * 1;
            }
            else
            {
                moveX = moveX * -1;
            }
            if (up)
            {
                moveY = moveY * 1;
            }
            else
            {
                moveY = moveY * -1;
            }


            transform.Translate(new Vector2(moveX, moveY));
            pos = transform.localPosition;

            if (pos.x > desPointX)
            {
                right = false;
            }
            if (pos.x < oriPointX)
            {
                right = true;
            }

            if (pos.y > desPointY)
            {
                up = false;
            }
            if (pos.y < oriPointY)
            {
                up = true;
            }
        }

        }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "player")
            collision.gameObject.transform.parent = null;
    }
}
