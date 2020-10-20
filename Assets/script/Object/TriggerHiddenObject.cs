using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerHiddenObject : MonoBehaviour
{
    public GameObject obj;
    public Rigidbody2D rigid;
    public float forceX = 0.1f;
    public BoxCollider2D col;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            obj.SetActive(true);
            rigid.gravityScale = 0;
            BoxCollider2D col = obj.GetComponent<BoxCollider2D>();
            if (col != null)
                col.enabled = false;
            
        }
        if (obj.activeSelf)
            {
                rigid.AddForce(new Vector2(forceX, 0));
                col.enabled = false;
                //if (obj.transform.position.x == 205.24f)
                //{

                //}
            }
        
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.tag=="trap")
        {
            rigid.AddForce(new Vector2(-forceX * 6, 0));
        }
    }
    private void Update()
    {
        
        
    }
    
}
