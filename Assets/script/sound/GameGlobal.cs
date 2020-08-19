using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameGlobal : MonoBehaviour
{
    public AudioSource[] bgmArray;
    public void Start()
    {
        DontDestroyOnLoad(this);

        bgmArray[(int)SCENE.START].Play();

        SceneManager.sceneLoaded += OnSceneLoaded;

    }

    public void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        foreach (AudioSource a in bgmArray)
        {

            a.Stop();

            if (scene.name == "LevelSelect")
            {
                
                bgmArray[(int)SCENE.SELECT].Play();
            }
            if (scene.name == "level1" || scene.name == "Level2" || scene.name == "Level3" || scene.name == "Level4")
            {
                
                bgmArray[(int)SCENE.LEVEL1].Play();

            }
            /*if (scene.name == "Level2")
            {
                bgmArray[(int)SCENE.LEVEL2].Play();
            }
            if (scene.name == "Level3")
            {
                bgmArray[(int)SCENE.LEVEL3].Play();
            }
            if (scene.name == "Level4")
            {
                bgmArray[(int)SCENE.LEVEL4].Play();
            }*/
            if (scene.name == "Level5" || scene.name == "Level6")
            {

                bgmArray[(int)SCENE.LEVEL5].Play();

            }
            /*if (scene.name == "Level6")
            {
                bgmArray[(int)SCENE.LEVEL6].Play();
            }*/
        }
    }

    
}
