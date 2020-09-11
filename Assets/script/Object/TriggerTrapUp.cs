using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerTrapUp : MonoBehaviour
{
    public GameObject obj;
    public float forceX = 0;
    public float forceY = 0.2f;
    public Rigidbody2D rigid;
    public BoxCollider2D col;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.tag == "Player")
        {
            obj.SetActive(true);
            if (obj.activeSelf)
            {
                rigid.AddForce(new Vector2(forceX, forceY));
            }
            if (col != null)
            col.enabled = false;
        }
    }
    
}
