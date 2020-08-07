using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    
    public GameObject telp;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        
        if (collision.tag == "Player")
        {

            collision.transform.position = telp.transform.position;
        }
    }
}
