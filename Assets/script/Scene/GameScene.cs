using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets._2D;

public class GameScene : BaseScene
{
    public Camera2DFollow CamFollow;
    public GameObject fall;
    public GameObject[] traps;
    public GameObject clear;
    public override void Init()
    {
        base.Init();

        for (int i = 0; i < traps.Length; i++)
        {
            Trap trap = traps[i].GetComponent<Trap>();
            trap.Init();
        }
        fall = GameObject.Find("fall");
        Fall falling = fall.GetComponent<Fall>();
        CamFollow = Camera.main.GetComponent<Camera2DFollow>();
        clear = GameObject.Find("clear");
        ClearCheck clearCheck = clear.GetComponent<ClearCheck>();

        clearCheck.Init();
        CamFollow.Init();
        falling.Init();
    }
}
