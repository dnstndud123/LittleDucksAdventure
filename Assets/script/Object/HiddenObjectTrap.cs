using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HiddenObjectTrap : MonoBehaviour
{
    public SpriteRenderer Pillar;
    public SpriteRenderer trap;
    public BoxCollider2D trapCol;
    public float span = 1;
    float delta = 0;
    float delta2 = 0;
    void Start()
    {
        Pillar.color = new Color(Pillar.color.r, Pillar.color.g, Pillar.color.b, 0);
        if (trap != null)
        {
            trap.color = new Color(trap.color.r, trap.color.g, trap.color.b, 0);
            trapCol.enabled = false;
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Rigidbody2D pl = PlayerControl.ins.gameObject.GetComponent<Rigidbody2D>();
            if (trap != null)
            {
                pl.bodyType = RigidbodyType2D.Static;
                pl.bodyType = RigidbodyType2D.Dynamic;
                pl.gravityScale = 0.01f;
                PlayerControl.ins.enabled = false;
            }
            StartCoroutine(AppearBlock());
            
        }
    }

    IEnumerator Appear()
    {
        

        while (delta <= span)
        {
            delta += Time.deltaTime;
            
            Color c = trap.color;
            trap.color = new Color(c.r, c.g, c.b, Mathf.Lerp(0, 1, delta / span));

            yield return null;
        }
        
        trapCol.enabled = true;
        
        delta = 0;
    }
    IEnumerator AppearBlock()
    {

        while (delta2 <= span)
        {
            delta2 += Time.deltaTime;

            Color c = Pillar.color;
            Pillar.color = new Color(c.r, c.g, c.b, Mathf.Lerp(0, 1, delta2 / span));

            yield return null;
        }
        //yield return new WaitForSeconds(1);
        if (trap != null)
        {
            StartCoroutine(Appear());
        }
            delta2 = 0;
    }
}
