using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SelectScene : BaseScene
{
    public ClearCheck clearCheck;

    public ClearClone[] clearArray;
    public GameObject clearList;
    [SerializeField] int stageNumber = 0;

    public override void Init()
    {   
        
        base.Init();

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
            clearArray[i - 1].gameObject.SetActive(true);
        }

        clearCheck.Init();



    }

}
