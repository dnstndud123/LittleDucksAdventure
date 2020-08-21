using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlFlip : MonoBehaviour
{   
    
    public float spd = 100;
    public float force = 5;
    private void OnTriggerStay2D(Collider2D collision)
    {
        PlayerControl pCon = collision.gameObject.GetComponent<PlayerControl>();
        Character2D char2D = collision.gameObject.GetComponent<Character2D>();
        if (collision.gameObject.tag == "Player")
        {
            char2D.multiple = 2;

            if (Input.GetKey(KeyCode.LeftArrow))
            {
                pCon.rigid.AddForce(new Vector2(pCon.speedX + spd, 0));
                
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                pCon.rigid.AddForce(new Vector2(-pCon.speedX - spd, 0));
                
            }


            //if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.Space))
            //{
                
            //}

        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        Character2D char2D = collision.gameObject.GetComponent<Character2D>();
        if (collision.gameObject.tag == "Player")
        {
            char2D.multiple = 1;
        }
    }


}
