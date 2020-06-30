using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float hp;
    public float maxHp = 3;
    public float speedX;
    public float maxSpeed;


    public Character2D char2D;
    public Rigidbody2D rigid;

    // Start is called before the first frame update
    void Start()
    {
        hp = maxHp;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.DownArrow))
        {
            char2D.Crouch(true);
            
            if (Input.GetKey(KeyCode.LeftArrow))
                char2D.Flip(false);
            if (Input.GetKey(KeyCode.RightArrow))
                char2D.Flip(true);
            return;
        }
        if(Input.GetKeyUp(KeyCode.DownArrow))
        {
            char2D.Crouch(false);
        }
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            rigid.AddForce(new Vector2(-speedX, 0));
            char2D.Flip(false);
        }
        if(Input.GetKey(KeyCode.RightArrow))
        {
            rigid.AddForce(new Vector2(speedX, 0));
            char2D.Flip(true);
        }

        Vector2 velX = rigid.velocity;
        float limitX = Mathf.Min(maxSpeed, velX.x);
        limitX = Mathf.Max(-maxSpeed,limitX);
        rigid.velocity = new Vector2(limitX, velX.y);

        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            char2D.Jump();
            
        }

        

        
    }
}
