using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class UiManager : MonoBehaviour
{
    public GameObject[] uiList;
    // Start is called before the first frame update
    void Start()
    {
        HideAll();

        Show("UiStart", uiList[0]);
    }

    public void HideAll()
    {
        GameObject ui = null;

        for (int i = 0; i < uiList.Length; i++)
        {
            ui = uiList[i];
            ui.SetActive(false);
        }
    }

    public void OnStart()
    {
        HideAll();

        Show("UiPlay", uiList[1]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //name에 해당하는 UI 키거나 끔
    //show가 ture면 키고 false면 끔
    public void Show(string name,bool show)
    {

        GameObject ui = null;

        for (int i = 0; i < uiList.Length; i++)
        {
            ui = uiList[i];
            if (ui.name == name)
            {
             // Debug.Log(ui.name);
              ui.SetActive(show);
            }
        }
        
    }
}
    
