using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets._2D;

public class SwitchTrap : MonoBehaviour
{
    public Animator anim;
    public SoundManager sM;

    public Rigidbody2D rigid;
    public GameObject trigger;
    public GameObject box;
    //public GameObject hideObj;
    //public BoxCollider2D col;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "JumpCheck")
        {
            Animator pl = collision.GetComponentInParent<Animator>();
            Camera2DFollow cam = Camera.main.GetComponent<Camera2DFollow>();
            trigger.SetActive(true);
            anim.SetBool("on", true);
            sM.Play("SwitchOn");
            box.transform.position = new Vector2(191.6f, box.transform.position.y);
            pl.gameObject.transform.position = new Vector3(transform.position.x, transform.position.y - 0.5f, 0);
            StartCoroutine(Hit(pl));
            rigid.bodyType = RigidbodyType2D.Dynamic;
            StartCoroutine(Fly());
            
            cam.target = null;
            
            

        }
        
    }
    IEnumerator Hit(Animator player)
    {
        yield return new WaitForSeconds(1.3f);
        player.SetBool("hurt", true);
    }
    IEnumerator Fly()
    {
        yield return new WaitForSeconds(1.5f);
        rigid.AddForce(new Vector2(0, 50000));
        sM.Play("SwitchUp");
    }
}
