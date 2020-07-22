using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class UIManager : MonoBehaviour
{
    public GameObject[] uiList;
    // Start is called before the first frame update
    void Start()
    {
        HideAll();
        Show("UIPlay", uiList[0]);
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
    public void Show(string name, bool show)
    {
        GameObject ui = null;
        for (int i = 0; i < uiList.Length; i++)
        {
            ui = uiList[i];
            if (ui.name == name)
            {
                ui.SetActive(show);
            }
        }
    }
    public void OnStart()
    {
        //SceneManager.LoadScene(1);
        HideAll();
        Show("UISelect", uiList[1]);

    }
    

}
