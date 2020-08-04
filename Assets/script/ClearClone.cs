using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearClone : MonoBehaviour
{

    public float _speedX;
    public float _speedY;
    private bool right = true;
    private bool up = true;
    public float desPointX; //des 목적지
    public float oriPointX; //ori 시작점
    public float desPointY;
    public float oriPointY;

    public float span;
    public float span2;
    public float delta;
    public float delta2;

    SoundManager sM;
    [SerializeField] Rigidbody2D rigid;
    public float jumpForce = 10;
    public Animator anim;
    //public GameObject btn;
    public string btnActive = "btnActive";
    // Start is called before the first frame update
    void Start()
    {

        sM = FindObjectOfType<SoundManager>();
        rigid = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        span = Random.Range(2.0f, 20.0f);
        span2 = Random.Range(5.0f, 20.0f);
    }

    private void Update()
    {
        Vector2 pos = rigid.transform.localPosition;
        delta2 += Time.deltaTime;
        if (delta2 < span2)
        {
            float moveX = Time.deltaTime * _speedX;
            float moveY = Time.deltaTime * _speedY;
            if (right == true)
            {
                moveX = moveX * 1;
            }
            else
            {
                moveX = moveX * -1;
            }
            if (up == true)
            {
                moveY = moveY * 1;
            }
            else
            {
                moveY = moveY * -1;
            }




            pos = rigid.transform.localPosition;




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
            rigid.AddForce(new Vector2(moveX, moveY));
            anim.SetFloat("velocity", Mathf.Abs(moveX));
        }
        if (delta2 > span2)
        {
            anim.SetFloat("velocity", 0);

        }
        if (delta2 > span2 + 5.0f)
            delta2 = 0;

        //랜덤 점프
        delta += Time.deltaTime;
        if (delta > span)
        {
            //점프
            rigid.AddForce(new Vector2(0, jumpForce));
            span = Random.Range(4.0f, 14.0f);

            delta = 0;
            anim.SetBool("jump", true);
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

    private void OnTriggerEnter2D(Collider2D collision)
    {

       
        if (collision.tag == "ground" || collision.tag == "fall")
        {
            anim.SetBool("jump", false);
        }

#if UNITY_ANDROID||UNITY_IOS
#endif
    }

}