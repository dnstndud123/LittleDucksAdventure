using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets._2D;

public class Spring : MonoBehaviour
{
    public Animator anim;
    
    public float trapForce = 4000;
    public float diyong = 0;
    

    protected virtual void OnTriggerEnter2D(Collider2D collision)
    {
        anim.SetTrigger("jump");
        SoundManager.ins.Play("spring");
        StartCoroutine(Boing());
        Rigidbody2D rigid = collision.gameObject.GetComponent<Rigidbody2D>();


        if (collision.gameObject.tag == "Player" || collision.gameObject.tag == "DiePlayer")
        {
            Camera2DFollow cam = Camera.main.GetComponent<Camera2DFollow>();
            cam.target = null;
            rigid.AddForce(new Vector2(diyong, trapForce));
            PlayerControl.ins.enabled = false;
        }
    }
    protected virtual void OnTriggerStay2D(Collider2D collision)
    {

        SoundManager.ins.Play("spring");
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
        SoundManager.ins.Play("boing");
        StopCoroutine(Boing());
    }

}
