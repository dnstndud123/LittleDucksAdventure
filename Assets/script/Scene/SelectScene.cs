using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class SelectScene : BaseScene
{

    //public GameManager gM;
    

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
        
        startP = GameObject.Find("StartPoint");
        soundMgr = GameObject.Find("SoundManager");
        //Vector3 startPos = startP.transform.position;
        
        //gM.Init(player);

        
         clearCheck = GetComponentInChildren<ClearCheck>();
        clearList = GameObject.Find("clearList");
        clearArray = clearList.GetComponentsInChildren<ClearClone>();
        

        stageNumber = PlayerPrefs.GetInt("LEVEL_DATA");
        sky = GameObject.Find("Sky").GetComponentsInChildren<SpriteRenderer>();
        skyColor = GameObject.Find("SkyColor").GetComponentsInChildren<SpriteRenderer>();

        cloud = GameObject.Find("Cloud").GetComponentsInChildren<SpriteRenderer>();
        cloudColor = GameObject.Find("CloudColor").GetComponentsInChildren<SpriteRenderer>();

        foreach (ClearClone cc in clearArray)
        {
            cc.gameObject.SetActive(false);
        }
        if (stageNumber == 0)
        {
            stageNumber += 1;
        }
        for (int i = 1; i < stageNumber; i++)
        {

            if (stageNumber > 1)
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
                else if (stageNumber >= 9 && stageNumber < 11)
                {
                    s.sprite = skyColor[2].sprite;
                    c.sprite = cloudColor[2].sprite;
                }
                else if (stageNumber >= 11)
                {
                    s.sprite = skyColor[0].sprite;
                    c.sprite = cloudColor[0].sprite;
                }
            }
        }


        clearCheck.Init();

        

    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            StartCoroutine(StartScene());
        }
    }
    IEnumerator StartScene()
    {
        yield return new WaitForSeconds(1.0f);
        SceneManager.LoadScene("Start");
    }
}
