using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets._2D;

public class GameScene : BaseScene
{
    
    public Camera2DFollow CamFollow;
    public GameObject fall;
    public Trap[] traps;
    public GameObject clear;
    public GameObject trapList;
    
    
    public override void Init()
    {


        base.Init();

        PlayerControl.ins.flip = true;
        GameObject gameMgrObj = GameObject.Find("GameManager");
        GameManager gameMgr = gameMgrObj.GetComponent<GameManager>();


        gameMgr.Init(player);
        fall = GameObject.Find("fall");
        Fall falling = fall.GetComponent<Fall>();
        CamFollow = Camera.main.GetComponent<Camera2DFollow>();
        clear = GameObject.Find("clear");
        ClearCheck clearCheck = clear.GetComponent<ClearCheck>();
        trapList = GameObject.Find("Traps");
        



        clearCheck.Init();
        CamFollow.Init();
        falling.Init();

        traps = trapList.GetComponentsInChildren<Trap>();
        foreach (Trap t in traps)
        {
            t.Init();
        }
        /*
        for (int i = 0; i < traps.Length; i++)
        {
            Trap trap = traps[i].GetComponent<Trap>();
            trap.Init();
        }
        */
    }
   

}
