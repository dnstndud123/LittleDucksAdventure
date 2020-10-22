using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIPlay : UIBase
{
    public GameObject gObj;
    public GameObject level;
    bool menu = false;

    public override void Init()
    {
        base.Init();
        int count = PlayerPrefs.GetInt("DEATH_COUNT");
        int lifeCount = count;
        if (txt != null) txt.text = lifeCount.ToString();
        
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            sM.Play("Select");
            if (menu == false)
            {
                gObj.SetActive(true);
                SoundManager.ins.volume.SetActive(true);
                //일시 정지
                Time.timeScale = 0.0f;
                menu = true;
            }
            else if (menu == true)
            {
                gObj.SetActive(false);
                SoundManager.ins.volume.SetActive(false);
                Time.timeScale = 1.0f;
                menu = false;
            }
        }
    }

    public override void OnButtonClick(GameObject btn)
    {
        sM.Play("Select");

        if (btn.name == "option")
        {

            gObj.SetActive(true);
            SoundManager.ins.volume.SetActive(true);
            //일시 정지
            Time.timeScale = 0.0f;
            menu = true;


        }
        if (btn.name == "resume")
        {

            gObj.SetActive(false);
            SoundManager.ins.volume.SetActive(false);
            //일시 정지 풀기
            Time.timeScale = 1.0f;
            menu = false;
        }
        if (btn.name == "restart")
        {
            //gObj.SetActive(false);
            
            Time.timeScale = 1.0f;

            //현재 스테이지 다시 시작
            OnRestart(level);
            menu = false;


        }
        if (btn.name == "LevelSelect")
        {
            Time.timeScale = 1.0f;
            menu = false;
            StartCoroutine(OnPlay(btn.name));
            //SceneManager.LoadScene((int)SCENE.LEVEL_SELECT);
        }
        
    }
    
    

}

