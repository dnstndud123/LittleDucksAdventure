using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallenTrap : MonoBehaviour
{
    public Rigidbody2D trap1;
    public Rigidbody2D trap2;
    public Rigidbody2D trap3;
    public Rigidbody2D trap4;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player") 
        {
            trap1.simulated = true;
        }
        if (collision.tag == "fallen1")
        {
            trap2.simulated = true;
        }
        
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "fallen2")
        {
            trap3.simulated = true;
            trap4.simulated = true;
        }
    }
}
