using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    public Animator anim;
    //public SoundManager sM;
    public GameObject floor;
    public GameObject trigger;
    public GameObject hideObj;
    public BoxCollider2D col;

    public bool turn = false;

    public void Init()
    {
        if (trigger != null)
        {
            trigger.SetActive(false);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
            

        if (collision.tag == "JumpCheck" && turn == false)
        {
            
            anim.SetBool("TurnOn", true);
            SoundManager.ins.Play("SwitchOn");
            StartCoroutine(TurnOn(true));

            if (hideObj != null)
                hideObj.SetActive(false);

            if (floor != null)
            {
                Vector3 floorPos = floor.transform.position;
                floor.transform.position = new Vector3(floorPos.x, -22.4f, 0);
                col.enabled = false;
            }
            trigger.SetActive(true);
            
        }
        if (collision.tag == "JumpCheck" && turn == true)
        {
            anim.SetBool("TurnOn", false);
            SoundManager.ins.Play("Select2");
            StartCoroutine(TurnOn(false));

            if (hideObj != null)
                hideObj.SetActive(true);

            if (floor != null)
            {
                Vector3 floorPos = floor.transform.position;
                floor.transform.position = new Vector3(floorPos.x, -34.72f, 0);
                col.enabled = true;
            }
            trigger.SetActive(false);
        }
    }
    public IEnumerator TurnOn(bool turn)
    {
        yield return 0.5f;
        this.turn = turn;
    }
}
