using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapTeleport : MonoBehaviour
{
    public GameObject trap;
    public Rigidbody2D rigid;

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "fallen3")
        {
            trap.transform.position = this.transform.position;
            rigid.gravityScale = 0;
        }
    }
}
