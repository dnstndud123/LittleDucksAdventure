using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    [HideInInspector]
    static PlayerControl instance;
    public static PlayerControl ins
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<PlayerControl>();
                if (null == instance)
                {
                    Debug.LogError("PlayerControl 인스턴스 가져오기 실패");
                }

            }
            return instance;
        }
    }
    
    public float speedX;
    public float maxSpeed = 4;
    
    

    public Character2D char2D;
    public Rigidbody2D rigid;

    //public GameObject[] btns;
    

    

    

    
    // Update is called once per frame
    void Update()
    {
#if UNITY_ANDROID || UNITY_IOS

#endif
        if (char2D.hp == 0)
            return;


        /*  if(Input.GetKey(KeyCode.DownArrow))
          {

              char2D.Crouch(true);

              if (Input.GetKey(KeyCode.LeftArrow))
              {

                  char2D.Flip(false);
              }
              if (Input.GetKey(KeyCode.RightArrow))
              {

                  char2D.Flip(true);
              }


                  return;

          }
          if(Input.GetKeyUp(KeyCode.DownArrow))
          {
              char2D.Crouch(false);
          }
        */

        

        if(Input.GetKey(KeyCode.LeftArrow))
        {
            LeftMove(true, 0);
        }
        if(Input.GetKey(KeyCode.RightArrow))
        {
            RightMove(true, 0);
        }
       //if (speedX > 0)
       //    char2D.Flip(true);
       // if (speedX < 0)
       //     char2D.Flip(false);

        Vector2 velX = rigid.velocity;
        float limitX = Mathf.Min(maxSpeed, velX.x);
        limitX = Mathf.Max(-maxSpeed,limitX);
        rigid.velocity = new Vector2(limitX, velX.y);

        
        if(Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.Space))
        {
            char2D.Jump();
            

        }

        

        
    }
    public void LeftMove(bool left,float spd)
    {
        if (left == true)
        {
            rigid.AddForce(new Vector2(-speedX, 0));
            char2D.Flip(false);
        }
        else
        {
            rigid.AddForce(new Vector2(speedX + spd, 0));
            char2D.Flip(true);
        }
    }
    public void RightMove(bool right,float spd)
    {
        if (right == true)
        {
            rigid.AddForce(new Vector2(speedX, 0));
            char2D.Flip(true);
        }
        else
        {
            rigid.AddForce(new Vector2(-speedX - spd, 0));
            char2D.Flip(false);
        }
    }
}
