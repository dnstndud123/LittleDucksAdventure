using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpTrap : MonoBehaviour
{
    public GameObject obj;
    public float forceY = 500f;
    public Rigidbody2D rigid;
    public BoxCollider2D collider;
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "Player")
        {
            
            collider.enabled = false;
            rigid.AddForce(new Vector2(0, forceY));
        }
    }
}
