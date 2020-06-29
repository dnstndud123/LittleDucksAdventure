using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventurerCharacter2D : MonoBehaviour
{
    public PlayerAttack pAttack;
    public Rigidbody2D _rigid;
    public Animator _anim;
    public SoundManager sM;
    public float _jumpForce;
    public float _MaxVelY;
    public int _hp;
    public int maxHp = 100;
    public int atk = 10;
    public Text UiHp;
    // Start is called before the first frame update
    void Start()
    {
        _hp = maxHp;
        UiHp.text = _hp.ToString();

        
    }

    public void OnDamage(int damage)
    {
        _hp -= damage;
        _hp = Mathf.Max(0, _hp);
        UiHp.text = _hp.ToString();

        _anim.SetBool("hit", true);
        _anim.SetInteger("hp", _hp);
        sM.Play("hit_scream");
    }

    public void OnHeal(int Heal)
    {
        _hp += Heal;
        _hp = Mathf.Min(maxHp, _hp);
        UiHp.text = _hp.ToString();
        _anim.SetInteger("hp", _hp);
        
    }
    


    // Update is called once per frame
    void Update()
    {
        _anim.SetFloat("velocity", Mathf.Abs(_rigid.velocity.x));
        
    }
    //Flip함수는 방향전환 역할 해줌
    public void Flip(bool right)
    {
        Vector3 scale = transform.localScale;
        if (right == true)//오른쪽 바라볼 때(right true)
        {
            
            float newScaleX = Mathf.Abs(scale.x);
            transform.localScale = new Vector3(newScaleX, scale.y, scale.z);
        }
        else//왼쪽 바라볼 때 (right false)
        {
            float newScaleX = Mathf.Abs(scale.x);
            transform.localScale = new Vector3(-newScaleX, scale.y, scale.z);
        }
    }
    public void Jump()
    {

        bool isjump = _anim.GetBool("jump");
        
        if (isjump == true)
            return;
        _anim.SetBool("jump", true);
        _rigid.AddForce(new Vector2(0, _jumpForce));

            Vector2 vel = _rigid.velocity;
            float limit = Mathf.Min(_MaxVelY, vel.y);

            _rigid.velocity = new Vector2(vel.x, limit);
        
      
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ground")
        {
            _anim.SetBool("jump", false);
        }
    }
    public void Attack()
    {
        _anim.SetBool("attack",true);
    }

    
}
