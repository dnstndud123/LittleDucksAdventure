using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIHp2 : MonoBehaviour
{
    public Character2D player;
    public Animator anim;
    void Start()
    {
        player = FindObjectOfType<Character2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (player.hp < 2)
            anim.SetBool("die", true);
        else
            anim.SetBool("die", false);

    }
}
