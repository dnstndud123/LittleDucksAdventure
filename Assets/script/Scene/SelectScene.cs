using System.Collections;
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
        for (int i = 0; i < stageNumber; i++)
        {
            if (i == 0)
            {
                clearArray[0].gameObject.SetActive(true);
            }
            else
                clearArray[i - 1].gameObject.SetActive(true);
        }

        clearCheck.Init();

        

    }

}
