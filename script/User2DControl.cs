using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;


//descript 유저의 키 입력(나중에는 다시 입력까지)
public class User2DControl : MonoBehaviour
{
    public Rigidbody2D _rigid;
    public float _moveForce;
    public float _moveMax;

    public AdventurerCharacter2D char2D;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            _rigid.AddForce(new Vector2(-_moveForce, 0));
            char2D.Flip(false);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            _rigid.AddForce(new Vector2(_moveForce, 0));
            char2D.Flip(true);
        }

        if (Input.GetKeyDown(KeyCode.X))
        {

            char2D.Jump();

        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            char2D.Attack();
        }


        Vector2 vel = _rigid.velocity;
        

        //x쪽으로의 속도가 _moveMax를 넘지 않는다
        float newVelx = Mathf.Min(_moveMax, vel.x);

        //-x쪽으로의 속도가 -_moveMax를 넘지 않는다
        newVelx = Mathf.Max(-_moveMax, newVelx);

        _rigid.velocity = new Vector2(newVelx, vel.y);

        //float newVelY=Mathf.Min(_jumpMax,)
    }

   
}
