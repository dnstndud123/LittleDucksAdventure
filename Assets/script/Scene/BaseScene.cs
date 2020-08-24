using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BaseScene : MonoBehaviour
{
    public GameObject player;
    public GameObject startP;
    public GameObject soundMgr;
    


    

    private void Start()
    {
        Init();
        
    }
    public virtual void Init()
    {
        InitGameGlobal();

        if (this is StartScene || this is SelectScene)
        {
            //InitPlayer 스킵
        }
        
        else
        {
            InitPlayer();
            
            
        }
        Time.timeScale = 1.0f;
        

    }
    

    public void InitGameGlobal()
    {
        GameObject global = GameObject.Find("GameGlobal");
        if (global == null)
        {
            GameObject globalPrefab = Resources.Load("GameGlobal") as GameObject;
            global = Instantiate(globalPrefab);
            global.name = "GameGlobal";
        }
    }
    public void InitPlayer()
    {
        GameObject player = GameObject.Find("Player");
        startP = GameObject.Find("StartPoint");
        soundMgr = GameObject.Find("SoundManager");
        if (player == null)
        {
            GameObject p = Instantiate(this.player);
            p.name = "Player";
            player = p;
        }

        Character2D chr = player.GetComponent<Character2D>();
        chr.Init();


        Vector3 startPos = startP.transform.position;
        player.transform.position = new Vector3(startPos.x, startPos.y, startPos.z);
    }

    
}
