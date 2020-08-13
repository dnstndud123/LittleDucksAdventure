using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIPlay : UIBase
{
    public GameObject gObj;
    public GameObject level;


    

    public override void OnButtonClick(GameObject btn)
    {
        sM.Play("Select");

        if (btn.name == "option")
        {

            gObj.SetActive(true);
            //일시 정지
            Time.timeScale = 0.0f;


        }
        if (btn.name == "resume")
        {

            gObj.SetActive(false);
            Time.timeScale = 1.0f;
            //일시 정지 풀기
        }
        if (btn.name == "restart")
        {
            gObj.SetActive(false);
            Time.timeScale = 1.0f;

            //현재 스테이지 다시 시작
            OnRestart(level);


        }
        if (btn.name == "LevelSelect")
        {
            Time.timeScale = 1.0f;

            StartCoroutine(OnPlay(btn.name));
            //SceneManager.LoadScene((int)SCENE.LEVEL_SELECT);
        }
        
    }
    

}

