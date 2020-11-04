using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameGlobal : MonoBehaviour
{
    public AudioSource[] bgmArray;

    [SerializeField] Slider BGMSlider;

    const string BGM_VOLUME_DATA = "BGM_DATA";
    float value = 50;
    public void Start()
    {
        DontDestroyOnLoad(this);
        value = PlayerPrefs.GetInt(BGM_VOLUME_DATA);
        bgmArray[(int)SCENE.START].Play();

        SceneManager.sceneLoaded += OnSceneLoaded;
        SoundManager.ins.Init();
        


        if (SoundManager.ins.volume != null)
        {
            BGMSlider = GameObject.Find("BGM").GetComponentInChildren<Slider>(true);
            SoundManager.ins.volume.SetActive(false);
        }

        foreach (AudioSource a in bgmArray)
        {
            a.volume = PlayerPrefs.GetFloat(BGM_VOLUME_DATA) / 100;
        }


    }
    public void Update()
    {
        if (BGMSlider != null)
        {
            //PlayerPrefs.SetFloat(BGM_VOLUME_DATA, BGMSlider.value);
            
            value = BGMSlider.value;
            BGM_Volume(value);
            
        }
            
        
    }
    public void BGM_Volume(float value)
    {
        
        float volume = value / 100;
        foreach (AudioSource a in bgmArray)
        {
            a.volume = volume;
        }
        BGMSlider.value = volume * 100;
        PlayerPrefs.SetFloat(BGM_VOLUME_DATA, BGMSlider.value);
        
    }
    
    public void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (BGMSlider == null)
        {
            if (scene.name != "Start")
            {
                BGMSlider = GameObject.Find("BGM").GetComponentInChildren<Slider>(true);
            }
        }
        foreach (AudioSource a in bgmArray)
        {
            a.volume = PlayerPrefs.GetFloat(BGM_VOLUME_DATA) / 100;
        }
        if (scene.name != "LevelSelect")
            if (SoundManager.ins.volume != null)
                SoundManager.ins.volume.SetActive(false);

        if (BGMSlider != null)
            BGMSlider.value = PlayerPrefs.GetFloat(BGM_VOLUME_DATA);
        if (SoundManager.ins.SESlider != null)
            SoundManager.ins.SESlider.value = PlayerPrefs.GetFloat("SE_DATA");
        foreach (AudioSource a in bgmArray)
        {

            a.Stop();

            if (scene.name == "Start")
            {
                
                bgmArray[(int)SCENE.START].Play();
            }
            
            if (scene.name == "LevelSelect")
            {
                
                bgmArray[(int)SCENE.SELECT].Play();
            }
            if (scene.name == "Level1" || scene.name == "Level2" || scene.name == "Level3" || scene.name == "Level4")
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
            if (scene.name == "Level5" || scene.name == "Level6" || scene.name == "Level7" || scene.name == "Level8")
            {

                bgmArray[(int)SCENE.LEVEL5].Play();

            }
            if (scene.name == "Level9")
            {
                bgmArray[(int)SCENE.LEVEL9].Play();
            }
            if (scene.name == "Level10")
            {
                bgmArray[(int)SCENE.LEVEL10].Play();
            }
            /*if (scene.name == "Level6")
            {
                bgmArray[(int)SCENE.LEVEL6].Play();
            }*/
            
        }
    }

    
}
