using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character2D : MonoBehaviour
{
    protected Rigidbody2D rigid;
    protected Animator anim;
    public float forceY;
    public float maxForce;

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetFloat("velocity", Mathf.Abs(rigid.velocity.x));
    }

    public void Flip(bool right)
    {
        Vector2 scale = transform.localScale;
        
        if (right == true)
        {
            float scaleX = Mathf.Abs(scale.x);
            transform.localScale = new Vector2(scaleX, scale.y);
        }
        else
        {
            float scaleX = Mathf.Abs(scale.x);
            transform.localScale = new Vector2(-scaleX, scale.y);
        }
    }
    public void Jump()
    {
        bool isJump = anim.GetBool("jump");

        if (isJump == true)
            return;

        anim.SetBool("jump", true);
        rigid.AddForce(new Vector2(0, forceY));


            

            Vector2 velY = rigid.velocity;
            float limitY = Mathf.Min(maxForce, velY.y);

            rigid.velocity = new Vector2(velY.x, limitY);



    }
    public void Crouch(bool isCrouch)
    {
        
        if (isCrouch == true)
        {
            anim.SetBool("crouch", true);
            rigid.velocity = new Vector2(rigid.velocity.x, 0);
        }
        else
        {
            anim.SetBool("crouch", false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "ground")
        {
            anim.SetBool("jump", false);
        }
    }
}
