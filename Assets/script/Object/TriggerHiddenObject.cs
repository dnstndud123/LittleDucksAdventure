using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerHiddenObject : MonoBehaviour
{
    public GameObject obj;
    public Rigidbody2D rigid;
    public float forceX = 0.1f;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            obj.SetActive(true);
            rigid.gravityScale = 0;
        }
         if (obj.activeSelf)
        {
            rigid.AddForce(new Vector2(forceX, 0));
            //if (obj.transform.position.x == 205.24f)
            //{

            //}
        }
        
    }
    private void Update()
    {
        
        
    }
    
}
