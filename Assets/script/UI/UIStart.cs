using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIStart : UIBase
{



    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    public override void OnButtonClick(GameObject btn)
    {
        sM.Play("Select");
        StartCoroutine(OnPlay(btn.name));
            
    }
}
