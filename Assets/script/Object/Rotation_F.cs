using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets._2D;

public class Rotation_F : MonoBehaviour
{
    public float rotate;
    public float speed = 1;
    public float mul;
    public float pow = 1;

    // Update is called once per frame
    void Update()
    {
        Vector3 rot = new Vector3(0, 0, 0);
        transform.rotation = Quaternion.Euler(new Vector3(rot.x, rot.y, rot.z));
        transform.Rotate(0, 0, speed * rotate--);
        if (rotate < -360.0f / speed)
        {
            rotate = 0;
        }
        if (transform.rotation.z <= 0 && transform.rotation.z > -180)
        {
            pow = -1;
        }
        else if (transform.rotation.z <= 180 && transform.rotation.z > 0)
        {
            pow = 1;
        }
        mul = speed * 50;
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Rigidbody2D rigid = collision.gameObject.GetComponent<Rigidbody2D>();
            
            rigid.AddForce(new Vector2(mul * pow, mul * -pow));

            Camera2DFollow cam = Camera.main.GetComponent<Camera2DFollow>();
            cam.target = null;
        }
    }
}
