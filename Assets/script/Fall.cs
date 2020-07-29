using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fall : MonoBehaviour
{


    public Character2D chr;
    public GameObject player;

    // Start is called before the first frame update
    public void Init()
    {
        player = GameObject.Find("Player");
        chr = player.GetComponent<Character2D>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            chr.OnDamage(999);
            if (chr.hp == 0)
                chr.tag = "DiePlayer";

        }
        if (collision.tag == "ClearPlayer")
        {
            chr.OnDamage(0);


        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Player")
        { 
            chr.OnDamage(999);
            if (chr.hp == 0)
                chr.tag = "DiePlayer";

        }
        if (collision.gameObject.tag == "ClearPlayer")
        {
            chr.OnDamage(0);


        }


    }


 
    // Update is called once per frame
    
}
