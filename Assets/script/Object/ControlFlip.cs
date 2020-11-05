using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlFlip : MonoBehaviour
{   
    
    //public float spd = 100;
    public float force = 5;
    public Button left;
    public Button right;
    private void OnTriggerStay2D(Collider2D collision)
    {
        PlayerControl pCon = collision.gameObject.GetComponent<PlayerControl>();
        Character2D char2D = collision.gameObject.GetComponent<Character2D>();
        if (collision.gameObject.tag == "Player")
        {
            char2D.multiple = 2;
            PlayerControl.ins.flip = false;

            
            left.gameObject.name = "Right";
            right.gameObject.name = "Left";


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
            PlayerControl.ins.flip = true;
            left.gameObject.name = "Left";
            right.gameObject.name = "Right";

        }
    }


}
