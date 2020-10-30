using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideTrapTrigger : MonoBehaviour
{
    public BoxCollider2D[] cols;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            foreach (BoxCollider2D b in cols)
            {
                b.enabled = false;
            }
        }
    }

}
