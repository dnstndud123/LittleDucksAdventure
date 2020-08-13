using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapSummon : MonoBehaviour
{
    public GameObject trap;
    public Rigidbody2D rigid;
    public float forceX;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            trap.SetActive(true);
            rigid.AddForce(new Vector2(forceX, 0));
            rigid.gravityScale = 0;
        }
    }
}
