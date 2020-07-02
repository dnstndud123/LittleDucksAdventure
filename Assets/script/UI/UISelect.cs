using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UISelect : MonoBehaviour
{

    public GameManager gM;
    public UIManager uM;
    public Rigidbody2D rigid;
    public Character2D player;
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<Character2D>();
        gM = FindObjectOfType<GameManager>();
        uM = FindObjectOfType<UIManager>();
    }

    
    public void OnStart(int number)
    {
        player.hp = player.maxHp;
        anim.SetBool("die", false);
        uM.HideAll();
        uM.Show("UIPlay", uM.uiList[2]);
        gM.NextStage(number);
        rigid.simulated = true;
        gM.ClearRespawn(number);
        
        

    }
}
