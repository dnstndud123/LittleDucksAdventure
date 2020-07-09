using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideTrap : Trap
{
    protected override void OnTriggerEnter2D(Collider2D collision)
    {
        base.OnTriggerEnter2D(collision);
        if (collision.gameObject.tag == "Player")
        {

            player.OnDamage(3);
            if (player.hp == 0)
                player.tag = "DiePlayer";
        }
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {

            player.OnDamage(3);
            if (player.hp == 0)
                player.tag = "DiePlayer";
        }
    }
}
