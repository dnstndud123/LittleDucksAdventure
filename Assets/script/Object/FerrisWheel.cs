using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets._2D;

public class FerrisWheel : MonoBehaviour
{
    [SerializeField] Character2D player;
    void OnTriggerStay2D(Collider2D collision)
    {
        
        if (collision.gameObject.tag == "GroundCheck")
        {
            player = collision.gameObject.GetComponentInParent<Character2D>();
            player.transform.parent = transform;
            Camera2DFollow cam = Camera.main.GetComponent<Camera2DFollow>();
            cam.target = player.transform;
            //collision.gameObject.transform.parent = transform;
        }

    }
    void OnTriggerExit2D(Collider2D collision)
    {
        
        if (collision.gameObject.tag == "GroundCheck")
        {
            player = collision.gameObject.GetComponentInParent<Character2D>();
            player.transform.parent = null;
            Camera2DFollow cam = Camera.main.GetComponent<Camera2DFollow>();
            cam.target = player.transform;
        }
        
    }
}
