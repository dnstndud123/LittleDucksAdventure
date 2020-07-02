using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapClone : Trap
{
    protected override void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            player.OnDamage(0);
        }
    }
}
