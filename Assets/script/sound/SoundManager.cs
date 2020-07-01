using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource[] audioList;
    // Start is called before the first frame update
    void Start()
    {
        
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
    // Update is called once per frame
 
}
