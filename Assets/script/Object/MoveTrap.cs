using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTrap : MonoBehaviour
{
    public float _speedX;

    public float oriPoint;
    public float desPoint;
    bool right = true;


    // Update is called once per frame
    void Update()
    {

        float moveX = Time.deltaTime * _speedX;

        if (right == true)
        {
            moveX = moveX * 1;
        }
        else
        {
            moveX = moveX * -1;
        }


        Vector2 pos = transform.localPosition;

        if (pos.x < oriPoint)
        {
            right = true;
        }
        if (pos.x > desPoint)
        {
            right = false;
        }



        transform.Translate(new Vector2(moveX, 0));






    }
}
