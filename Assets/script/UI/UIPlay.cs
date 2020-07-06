using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIPlay : UIBase
{
    public GameObject gObject;
    public override void OnButtonClick(GameObject btn)
    {
        base.OnButtonClick(btn);
        if (btn.name == "option")
        {
            
            gObject.SetActive(true);
            //일시 정지
            
        }
        if (btn.name == "resume")
        {
            gObject.SetActive(false);
            //일시 정지 풀기
        }
        if (btn.name == "restart")
        {
            gObject.SetActive(false);
            
            
        }
        if (btn.name == "select")
        {
            gObject.SetActive(false);
            uM.Show("UISelect", uM.uiList[1]);
        }
    }

}

