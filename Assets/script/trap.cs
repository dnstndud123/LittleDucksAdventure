using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Trap : MonoBehaviour
{
    protected Character2D player;
    


    // Start is called before the first frame update
    protected void Start()
    {
        player = player = FindObjectOfType<Character2D>();
        
    }
    protected virtual void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            
            player.OnDamage(1);
        }
    }

    
    
    // Update is called once per frame

}
