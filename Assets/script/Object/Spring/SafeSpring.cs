using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SafeSpring : MonoBehaviour
{

    public Animator anim;
    public AudioSource spring;
    public AudioSource boing;
    public float trapForce = 4000;
    public float diyong = 0;


    protected virtual void OnTriggerEnter2D(Collider2D collision)
    {
        anim.SetTrigger("jump");
        spring.Play();
        StartCoroutine(Boing());
        Rigidbody2D rigid = collision.gameObject.GetComponent<Rigidbody2D>();

        
        if (rigid != null)
        {
            
            rigid.bodyType = RigidbodyType2D.Kinematic;
            
            rigid.bodyType = RigidbodyType2D.Dynamic;
        }
        if (collision.gameObject.tag == "Player" || collision.gameObject.tag == "DiePlayer")
        {
            
            rigid.AddForce(new Vector2(diyong, trapForce));
            PlayerControl.ins.enabled = false;
        }
    }
    protected virtual void OnTriggerStay2D(Collider2D collision)
    {

        spring.Play();
        StartCoroutine(Boing());
        Rigidbody2D rigid = collision.gameObject.GetComponent<Rigidbody2D>();
        if (collision.gameObject.tag != "Player")
        {

            rigid.AddForce(new Vector2(diyong, trapForce));
        }
    }

    IEnumerator Boing()
    {
        yield return new WaitForSeconds(0.1f);
        boing.Play();
    }


}
