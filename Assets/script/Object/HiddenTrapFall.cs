using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HiddenTrapFall : MonoBehaviour
{
    public GameObject obj;
    public Rigidbody2D rigid;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            obj.SetActive(true);
            if(obj.activeSelf)
            {
                rigid.simulated = true;
            }
        }
    }
}
