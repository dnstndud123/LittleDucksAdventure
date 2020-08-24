using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwicthTrap : MonoBehaviour
{
    public Animator anim;
    public SoundManager sM;
    
    public GameObject trigger;
    //public GameObject hideObj;
    //public BoxCollider2D col;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "JumpCheck")
        {
            
            trigger.SetActive(true);
            anim.SetBool("on", true);
            sM.Play("SwitchOn");
            
            
            

        }
        
    }
}
