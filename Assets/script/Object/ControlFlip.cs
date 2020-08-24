using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlFlip : MonoBehaviour
{
    public float spd = 10;
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            PlayerControl pCon = collision.gameObject.GetComponent<PlayerControl>();
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                pCon.rigid.AddForce(new Vector2(pCon.speedX + spd, 0));
                
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                pCon.rigid.AddForce(new Vector2(-pCon.speedX - spd, 0));
                
            }
        }
    }
    
}
