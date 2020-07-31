using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Trap : MonoBehaviour
{
    [SerializeField] protected GameObject player;
    public GameObject gO;
    [SerializeField] protected Character2D chr;
    [SerializeField] protected Rigidbody2D rigid;

    
    public void Init()
    {
        player = GameObject.Find("Player");
        chr = player.GetComponent<Character2D>();
        rigid = GetComponent<Rigidbody2D>();
        
    }
    protected virtual void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            
            chr.OnDamage(1);
            if (chr.hp == 0)
                player.tag = "DiePlayer";
            gO.SetActive(true);
            
        }
        //if (collision.gameObject.tag == "ClearPlayer")
        //{

            //chr.OnDamage(0);
            
        //}
    }

    
    
    // Update is called once per frame

}
