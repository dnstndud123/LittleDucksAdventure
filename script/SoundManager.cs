using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource[] soundList;
    // Start is called before the first frame update
    void Start()
    {
        /*   for(int i=0;i<9;i++)
           {
               AudioSource snd = soundList[i];
               Debug.Log(snd.name);
           }
        */
        Play("shield bash impact");

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //name에 해당하는 소리 재생
    //name은 소리파일 이름
    public void Play(string name)
    {
        AudioSource snd = null;
        for (int i = 0; i < soundList.Length; i++)
        {
            snd = soundList[i];

            if (snd.name == name)
            {
               // Debug.Log(snd.name);
                snd.Play();
            }
        }
    }
}
