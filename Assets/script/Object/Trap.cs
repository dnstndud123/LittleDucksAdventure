using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Trap : MonoBehaviour
{
    [SerializeField] protected GameObject player;
    public GameObject gO;
    [SerializeField] protected Character2D chr;


    
    public void Init()
    {
        player = GameObject.Find("Player");
        chr = player.GetComponent<Character2D>();
        
    }
    protected virtual void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            
            chr.OnDamage(1);
            gO.SetActive(true);
            if (chr.hp == 0)
                player.tag = "DiePlayer";
        }
        //if (collision.gameObject.tag == "ClearPlayer")
        //{

            //chr.OnDamage(0);
            
        //}
    }

    
    
    // Update is called once per frame

}
