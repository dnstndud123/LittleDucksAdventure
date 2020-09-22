﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SelectScene : BaseScene
{

    public GameManager gM;
    

    public ClearCheck clearCheck;

    public ClearClone[] clearArray;
    public GameObject clearList;
    [SerializeField] int stageNumber = 0;
    [SerializeField] SpriteRenderer[] sky;
    [SerializeField] SpriteRenderer[] skyColor;

    [SerializeField] SpriteRenderer[] cloud;
    [SerializeField] SpriteRenderer[] cloudColor;

    public override void Init()
    {
        
        base.Init();
        GameObject player = GameObject.Find("Player");
        startP = GameObject.Find("StartPoint");
        soundMgr = GameObject.Find("SoundManager");
        Vector3 startPos = startP.transform.position;
        player.transform.position = new Vector3(startPos.x, startPos.y, startPos.z);
        gM.Init(player);

        GameObject clear = GameObject.Find("clear");
         clearCheck = clear.GetComponent<ClearCheck>();
        clearList = GameObject.Find("clearList");
        clearArray = clearList.GetComponentsInChildren<ClearClone>();
        foreach(ClearClone cc in clearArray)
        {
            cc.gameObject.SetActive(false);
        }

        stageNumber = PlayerPrefs.GetInt("LEVEL_DATA");
        sky = GameObject.Find("Sky").GetComponentsInChildren<SpriteRenderer>();
        skyColor = GameObject.Find("SkyColor").GetComponentsInChildren<SpriteRenderer>();

        cloud = GameObject.Find("Cloud").GetComponentsInChildren<SpriteRenderer>();
        cloudColor = GameObject.Find("CloudColor").GetComponentsInChildren<SpriteRenderer>();
        for (int i = 0; i < stageNumber; i++)
        {
            if (i == 0)
            {
                clearArray[0].gameObject.SetActive(true);
            }
            else
                clearArray[i - 1].gameObject.SetActive(true);
        }
        foreach (SpriteRenderer s in sky)
        {
            foreach (SpriteRenderer c in cloud)
            {
                if (stageNumber < 5)
                {
                    s.sprite = skyColor[0].sprite;
                    c.sprite = cloudColor[0].sprite;
                }
                else if (stageNumber >= 5 && stageNumber < 9)
                {
                    s.sprite = skyColor[1].sprite;
                    c.sprite = cloudColor[1].sprite;
                }
                else if (stageNumber == 9)
                {
                    s.sprite = skyColor[2].sprite;
                    c.sprite = cloudColor[2].sprite;
                }
                else if (stageNumber == 10)
                {
                    s.sprite = skyColor[0].sprite;
                    c.sprite = cloudColor[0].sprite;
                }
            }
        }


        clearCheck.Init();

        

    }

}
