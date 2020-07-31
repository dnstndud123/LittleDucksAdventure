using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIPlay : UIBase
{
    public GameObject gObj;
    public GameObject level;


    public void Init()
    {
        
    }
    public override void OnButtonClick(GameObject btn)
    {
        base.OnButtonClick(btn);
                    
            if (btn.name == "option")
            {

                gObj.SetActive(true);
                //일시 정지

            }
            if (btn.name == "resume")
            {
                gObj.SetActive(false);
                //일시 정지 풀기
            }
            if (btn.name == "restart")
            {
                gObj.SetActive(false);
                //현재 스테이지 다시 시작
                OnRestart(level);


            }
            if (btn.name == "select")
            {

                SceneManager.LoadScene((int)SCENE.LEVEL_SELECT);
            }
        
    }
    public void OnRestart(GameObject level)
    {
        SceneManager.LoadScene(level.name);
    }

}

