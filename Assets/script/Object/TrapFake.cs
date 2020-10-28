using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapFake : MonoBehaviour
{
    public GameObject obj1;
    public GameObject obj2;
    public float posX;

    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            
            
            StartCoroutine(Wide());
        }
    }
    IEnumerator Wide()
    {
        BoxCollider2D col = GetComponent<BoxCollider2D>();
        obj1.transform.Translate(new Vector2(-posX, 0));
        obj2.transform.Translate(new Vector2(posX, 0));

        yield return new WaitForSeconds(0.1f);
        col.enabled = false;
        
    }
}
