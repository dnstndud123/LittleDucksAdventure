using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Cinemachine.Examples;

public class UISelect : UIBase
{
   
    
    

    //public void OnStart(int number)
    //{
    //    StartCoroutine(OnPlay());
    //    SceneManager.LoadScene(number + 1);
        
         
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
        
        
    //}
  /*  private void Update()
    {
        if (number > 0)
        {
            delta += Time.deltaTime;
            uL.SetActive(true);

            if (delta > waitTime)
            {
                
                delta = 0;
                uL.SetActive(false);
                
                number = 0;
            }
        
        }
       
    }
  */

    public override void OnButtonClick(GameObject btn)
    {

        base.OnButtonClick(btn);
    }
}
