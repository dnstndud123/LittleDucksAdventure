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
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            rigid.AddForce(new Vector2(-speedX, 0));
        }
        if(Input.GetKey(KeyCode.RightArrow))
        {
            rigid.AddForce(new Vector2(speedX, 0));
        }

        Vector2 vel = rigid.velocity;
        float limit = Mathf.Min(maxSpeed, vel.x);
        limit = Mathf.Max(-maxSpeed,limit);
        rigid.velocity = new Vector2(limit, vel.y);

        
    }
}
