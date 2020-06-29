using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    public float _speed;
    public float _speedMax;
    public Rigidbody2D _rigid;
    public Character _char;
    public SoundMngr sm;
    public Animator _anim;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool isJump = _anim.GetBool("jump");
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            _rigid.AddForce(new Vector3(-_speed, 0, 0));
            _char.Flip(false);


        }
        if(Input.GetKey(KeyCode.RightArrow))
        {
            _rigid.AddForce(new Vector3(_speed, 0, 0));
            _char.Flip(true);

        }


        if (Input.GetKeyDown(KeyCode.UpArrow) && isJump == false)
        {
            sm.Play("jump");
            _char.Jump();
        }
        
        

        Vector2 vel = _rigid.velocity;

        float limit = Mathf.Min(_speedMax, vel.x);

        limit = Mathf.Max(-_speedMax, limit);

        _rigid.velocity = new Vector2(limit, vel.y);
        if (Input.GetKey(KeyCode.DownArrow))
        {
            _char.Crouch(true);
            if (Input.GetKey(KeyCode.LeftArrow))
                _rigid.velocity = new Vector2(-2.0f, 0);
            if (Input.GetKey(KeyCode.RightArrow))
                _rigid.velocity = new Vector2(2.0f, 0);
        }

        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            _char.Crouch(false);
        }
        if (_char.hp == 0)
        {
            _rigid.simulated = false;
        }
    }
}
