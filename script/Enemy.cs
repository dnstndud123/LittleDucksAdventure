using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float _speedX;
    public float _speedY;
    public int atk;
    //   public Rigidbody2D _rigid;
    protected bool right = true;
    protected bool up = true;
    public int _hp;
    public int maxHp;
    protected Animator anim;



    public float desPointX; //des 목적지
    public float oriPointX; //ori 시작점
    public float desPointY;
    public float oriPointY;
    //public AdventurerCharacter2D player;

    public GameObject _efctPrefab;
    // Start is called before the first frame update
    void Start()
    {
        _hp = maxHp;

        anim = gameObject.GetComponent<Animator>();
    }

    public virtual void OnDamage(int damage)
    {
        
        _hp -= damage;
        _hp = Mathf.Max(0, _hp);

        if (_hp == 0)
        {
            anim.SetBool("die", true);

        }


    }
    // Update is called once per frame
    void Update()
    {
        bool die = anim.GetBool("die");
        if (die == true)
        {
            return;
        }
        Vector2 pos = transform.localPosition;

        float moveX = Time.deltaTime * _speedX;
        float moveY = Time.deltaTime * _speedY;
        if (right)
        {
            moveX = moveX * 1;
        }
        else
        {
            moveX = moveX * -1;
        }
        if (up)
        {
            moveY = moveY * 1;
        }
        else
        {
            moveY = moveY * -1;
        }


        transform.Translate(new Vector2(moveX, moveY));
        pos = transform.localPosition;

        if (pos.x > desPointX)
        {
            right = false;
            Flip(right);
        }
        if (pos.x < oriPointX)
        {
            right = true;
            Flip(right);
        }

        if (pos.y > desPointY)
        {
            up = false;
        }
        if (pos.y < oriPointY)
        {
            up = true;
        }






    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "player")
        {
            AdventurerCharacter2D player = FindObjectOfType<AdventurerCharacter2D>();
            player.OnDamage(atk);
            GameObject efctfap = Instantiate(_efctPrefab);
            Vector2 charPos = player.transform.position;
            efctfap.transform.position = new Vector2(charPos.x, charPos.y);
        }
    }
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
}
