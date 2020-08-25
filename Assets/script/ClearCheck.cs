using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearCheck : MonoBehaviour
{
    public float _speedX;
 
    private bool right = true;

    public float desPointX; //des 목적지
    public float oriPointX; //ori 시작점


    public float span;
    public float span2;
    public float delta;
    public float delta2;

    public int stageNumber;
    public Character2D char2D;
    public UIManager uM;
    SoundManager sM;
    [SerializeField] Rigidbody2D rigid;
    public float jumpForce = 10;
    public GameObject clearCheck;
    public GameObject player;
    public Animator anim;
    //public GameObject btn;
    public string btnActive = "btnActive";
    // Start is called before the first frame update
    public void Init()
    {
        rigid = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        
        sM = FindObjectOfType<SoundManager>();

        char2D = player.GetComponent<Character2D>();
        player = GameObject.Find("Player");
        uM = FindObjectOfType<UIManager>();
        
        span = Random.Range(2.0f, 20.0f);
        span2 = Random.Range(5.0f, 20.0f);
    }

    private void Update()
    {
        //Vector2 pos = rigid.transform.localPosition;
        delta2 += Time.deltaTime;
        if (delta2 < span2)
        {
            float moveX = Time.deltaTime * _speedX;
            
            if (right == true)
            {
                moveX = moveX * 1;
            }
            else
            {
                moveX = moveX * -1;
            }
            
            
            


            Vector2 pos = rigid.transform.localPosition;




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

            
            rigid.AddForce(new Vector2(moveX, 0));
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
        if( delta > span )
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
    
    const string level_data = "LEVEL_DATA";
    
    public void LevelDataSave()
    
    {

        int lastLevel = 0;
        if (PlayerPrefs.HasKey(level_data))
        {
            lastLevel = stageNumber;   
        }        
        lastLevel += 1;

        PlayerPrefs.SetInt(level_data, lastLevel);    
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "Player")
        {
            sM.Play("Score");
            uM.HideAll();
            uM.Show("UIClear", uM.uiList[3]);
            player.tag = "ClearPlayer";
            //btn.SetActive(true);
            
            clearCheck.SetActive(false);

            LevelDataSave();
            



        }
        if (collision.tag == "ground" || collision.tag == "fall")
        {
                anim.SetBool("jump", false);
        }

        
#if UNITY_ANDROID||UNITY_IOS
#endif
    }

}
