using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public Animator _anim;
    public Rigidbody2D _rigid;
    public float jumpForce;
    public float jumpMax;
    public int hp;
    

    
    // Start is called before the first frame update
    void Start()
    {
        hp = 3;
    }

    public void OnDamage(int damage)
    {
        hp -= damage;



        _anim.SetBool("hit", true);
        _anim.SetInteger("hp", hp);
    }
    public void OnHeal(int heal)
    {
        hp += heal;




        _anim.SetInteger("hp", hp);
    }
    // Update is called once per frame
    void Update()
    {
        _anim.SetFloat("velocity", Mathf.Abs(_rigid.velocity.x));
    }
    public void Flip(bool right)
    {
        Vector3 scale = transform.localScale;
        float scaleX = Mathf.Abs(scale.x);
        if (right == true)
        {
            transform.localScale = new Vector3(scaleX, scale.y, scale.z);

        }
        else
        {
            transform.localScale = new Vector3(-scaleX, scale.y, scale.z);
        }
    }

    public void Crouch(bool isCrouch)
    {
        if (isCrouch == true)
            _anim.SetBool("crouch", true);
        else
            _anim.SetBool("crouch", false);
        
        
    }

    public void Jump()
    {
        bool isJump = _anim.GetBool("jump");
        if (isJump == true)
            return;
        _anim.SetBool("jump", true);
        _rigid.AddForce(new Vector2(0, jumpForce));
        Vector2 vel = _rigid.velocity;
        float limit = Mathf.Min(jumpMax, vel.y);
        _rigid.velocity = new Vector2(vel.x, limit);
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ground")
        {
            _anim.SetBool("jump", false);
        }
    }


}
