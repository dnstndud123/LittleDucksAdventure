using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets._2D;

public class Spring : MonoBehaviour
{
    public Animator anim;
    public AudioSource spring;
    public AudioSource boing;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        anim.SetTrigger("jump");
        spring.Play();
        StartCoroutine(Boing());
        Rigidbody2D rigid = collision.gameObject.GetComponent<Rigidbody2D>();
        rigid.AddForce(new Vector2(0, 4000));
        
        if (collision.gameObject.tag == "Player")
        {
            Camera2DFollow cam = Camera.main.GetComponent<Camera2DFollow>();
            cam.target = null;
        }
    }

    IEnumerator Boing()
    {
        yield return new WaitForSeconds(0.1f);
        boing.Play();
    }

}
