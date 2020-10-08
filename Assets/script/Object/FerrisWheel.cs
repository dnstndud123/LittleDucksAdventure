using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FerrisWheel : MonoBehaviour
{
    [SerializeField] Character2D player;
    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "GroundCheck")
        {
            player = collision.gameObject.GetComponentInParent<Character2D>();
            player.transform.parent = transform;
            //collision.gameObject.transform.parent = transform;
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "GroundCheck")
        {
            player = collision.gameObject.GetComponentInParent<Character2D>();
            player.transform.parent = null;
        }
    }
}
