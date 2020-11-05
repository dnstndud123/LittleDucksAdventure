using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScene : BaseScene
{
    // Start is called before the first frame update
    public override void Init()
    {
        
        //PlayerPrefs.DeleteKey("SE_DATA");
        //PlayerPrefs.DeleteKey("BGM_DATA");
        base.Init();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(OnSelect());
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            StartCoroutine(Quit());
        }
    }
    IEnumerator OnSelect()
    {
        yield return new WaitForSeconds(1.0f);
        SceneManager.LoadScene("LevelSelect");
    }
    IEnumerator Quit()
    {
        SoundManager.ins.Play("Fall");
        yield return new WaitForSeconds(1.0f);
        Application.Quit();
    }

}
