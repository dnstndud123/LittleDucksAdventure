using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundMngr : MonoBehaviour
{
    public AudioSource[] audioList;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Play(string name)
    {
        AudioSource sound = null;
        for (int i = 0; i < audioList.Length; i++)
        {
            sound = audioList[i];

            if (sound.name == name)
            {
                sound.Play();
            }
        }
    }
}
