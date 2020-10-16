using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    [HideInInspector]
    static SoundManager instance;
    public static SoundManager ins
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<SoundManager>();
                if(null==instance)
                {
                    Debug.LogError("SoundManager를 가져올 수 없소.");
                }
            }
            return instance;
        }
    }

    public Slider SESlider;
    float value = 50;
    public GameObject volume;

    public AudioSource[] audioList;

    const string SE_VOLUME_DATA = "SE_DATA";
    public void Init()
    {
        //SESlider = GameObject.Find("SE").GetComponentInChildren<Slider>(true);
        audioList = GetComponentsInChildren<AudioSource>(true);
            foreach (AudioSource a in audioList)
        {
            a.volume = PlayerPrefs.GetFloat(SE_VOLUME_DATA) / 100;
        }
        
        
    }

    public void Play(string name)
    {
        AudioSource snd = null;

        for (int i = 0; i < audioList.Length; i++)
        {
            
            snd = audioList[i];
            
            if(snd.name==name)
            {
                snd.Play();
            }
            snd.volume = PlayerPrefs.GetFloat(SE_VOLUME_DATA) / 100;
        }
        
    }
    public void Update()
    {
        if (SESlider != null)
        {
            value = SESlider.value;
            SE_Volume(value);
            
            
        }
    }
    public void SE_Volume(float value)
    {
        
        
        float volume = value / 100;
        foreach (AudioSource a in audioList)
        {
            a.volume = volume;
            
        }
        SESlider.value = volume * 100;
        PlayerPrefs.SetFloat(SE_VOLUME_DATA, SESlider.value);
        
           
        

    }
    // Update is called once per frame
 
}
