using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UISelect : UIBase
{

    
  

    
    public void OnStart(int number)
    {
        // SceneManager.LoadScene(number+1);
        /*  player.hp = player.maxHp;
          anim.SetBool("die", false);
          uM.HideAll();
          uM.Show("UIPlay", uM.uiList[2]);
          gM.NextStage(number);
          rigid.simulated = true;
          gM.ClearRespawn(number);
          player.tag = "Player";
        */
        SceneManager.LoadScene(number + 1);
    }
    public override void OnButtonClick(GameObject btn)
    {

        base.OnButtonClick(btn);
    }
}
