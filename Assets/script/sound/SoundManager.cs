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

    [SerializeField] Slider SESlider;
    float value = 50;

    public AudioSource[] audioList;

    public void Init()
    {
        SESlider = GameObject.Find("SE").GetComponentInChildren<Slider>(true);
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
        }
    }
    public void Update()
    {
        
        value = SESlider.value;
        SE_Volume(value);
    }
    public void SE_Volume(float value)
    {
        
        
        float volume = value / 100;
        foreach (AudioSource a in audioList)
        {
            a.volume = volume;
            
        }
        SESlider.value = volume * 100;
    }
    // Update is called once per frame
 
}
