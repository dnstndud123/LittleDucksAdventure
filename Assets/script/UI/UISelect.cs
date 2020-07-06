using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UISelect : UIBase
{

    
  

    
    public void OnStart(int number)
    {
        
        player.hp = player.maxHp;
        anim.SetBool("die", false);
        uM.HideAll();
        uM.Show("UIPlay", uM.uiList[2]);
        gM.NextStage(number);
        rigid.simulated = true;
        gM.ClearRespawn(number);
        player.tag = "Player";
    }
    public override void OnButtonClick(GameObject btn)
    {
       
        sM.Play("Select");
    }
}
