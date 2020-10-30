using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlueTrap : MonoBehaviour
{
    public BoxCollider2D col;
    public Rigidbody2D rigid;
    public BoxCollider2D[] traps;
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            rigid = collision.gameObject.GetComponent<Rigidbody2D>();
            
            rigid.bodyType = RigidbodyType2D.Static;
            Animator pl = collision.gameObject.GetComponent<Animator>();
            StartCoroutine(Hit(pl));
        }
    }
    IEnumerator Hit(Animator player)
    {
        yield return new WaitForSeconds(1.3f);
        foreach (BoxCollider2D t in traps)
        {
            t.enabled = true;
        }
        rigid.bodyType = RigidbodyType2D.Dynamic;
        rigid.bodyType = RigidbodyType2D.Static;
        player.SetBool("hurt", true);
        
    }
}
