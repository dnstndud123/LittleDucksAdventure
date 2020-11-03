using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlueTrap : MonoBehaviour
{
    public GameObject col;
    public Rigidbody2D rigid;
    public BoxCollider2D[] traps;
    public CapsuleCollider2D plCol;
    
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            rigid = collision.gameObject.GetComponent<Rigidbody2D>();
            plCol = collision.gameObject.GetComponent<CapsuleCollider2D>();
            
            col.SetActive(true);
            
            
            
            
            StartCoroutine(Hit());
            StartCoroutine(Hide());
        }
    }
    IEnumerator Hit()
    {
        
        yield return new WaitForSeconds(1.3f);
        if (col.activeSelf == true)
        {
            foreach (BoxCollider2D t in traps)
            {
                t.enabled = true;
            }
        }
        
        //plCol.enabled = true;
        
        
        
        
    }
    IEnumerator Hide()
    {
        yield return new WaitForSeconds(2.0f);
        col.SetActive(false);
    }
}
