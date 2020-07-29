using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallTrap : MonoBehaviour
{
    [SerializeField] Rigidbody2D rigid;
    [SerializeField] BoxCollider2D box;
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        rigid.gravityScale = 0;
        box = GetComponent<BoxCollider2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            rigid.gravityScale = 1;
            box.isTrigger = true;
        }
    }

    
}
