using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchMove : MonoBehaviour
{
    public SoundManager sm;
    public PolygonCollider2D col;
    public Rigidbody2D rigid;
    public Animator anim;

    public BoxCollider2D cloud;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        anim = GetComponent<Animator>();
        if (collision.tag == "JumpCheck")
        {
            anim.SetBool("TurnOn", true);
            sm.Play("SwitchOn");
            col.isTrigger = false;
            rigid.gravityScale = 1;
            StartCoroutine(RightMove());
            StartCoroutine(ChangeTrigger());
        }
    }

    IEnumerator RightMove()
    {
        yield return new WaitForSeconds(2);
        rigid.AddForce(new Vector2(3000, 0));
    }
    IEnumerator ChangeTrigger()
    {
        yield return new WaitForSeconds(10);
        rigid.gravityScale = 0;
        col.isTrigger = true;
        cloud.enabled = true;
    }
}
