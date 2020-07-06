using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fall : MonoBehaviour
{


    public Character2D player;


    // Start is called before the first frame update
    private void Start()
    {

        player = FindObjectOfType<Character2D>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            player.OnDamage(999);


        }
        if (collision.tag == "ClearPlayer")
        {
            player.OnDamage(0);


        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Player")
        { 
            player.OnDamage(999);
            

        }
        if (collision.gameObject.tag == "ClearPlayer")
        {
            player.OnDamage(0);


        }


    }


 
    // Update is called once per frame
    
}
