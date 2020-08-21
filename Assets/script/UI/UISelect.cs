using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Cinemachine.Examples;

public class UISelect : UIBase
{

    public GameObject[] btn;
    ClearCheck c;
    [SerializeField] int stageNumber = 0;
    
    public override void Init()
    {
        base.Init();
        GameObject clear = GameObject.Find("clear");
        c = clear.GetComponent<ClearCheck>();

        foreach (GameObject b in btn)
        {
            b.SetActive(false);

        }
        btn[0].gameObject.SetActive(true);


        stageNumber = PlayerPrefs.GetInt("LEVEL_DATA");
        for (int i = 0; i < stageNumber; i++)
        {
            btn[i].gameObject.SetActive(true);
        }

        
        
    }

    public void OnReset()
    {
        foreach (GameObject b in btn)
        {
            b.SetActive(false);

        }
        btn[0].gameObject.SetActive(true);
        PlayerPrefs.SetInt("LEVEL_DATA", 0);
    }
    

    


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
