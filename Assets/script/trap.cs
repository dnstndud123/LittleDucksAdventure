using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trap : MonoBehaviour
{
    
    
    
    
    // Start is called before the first frame update

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Character2D player = FindObjectOfType<Character2D>();
            player.OnDamage(1);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)

    {
        if (collision.gameObject.tag == "Player")
        {
            Character2D player = FindObjectOfType<Character2D>();
            player.OnDamage(1);
        }
    }
    
    // Update is called once per frame

}
