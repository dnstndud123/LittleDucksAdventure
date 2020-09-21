using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIGameOver : UIBase
{
    public override void Init()
    {
        base.Init();

        if (txt != null) txt.text = PlayerPrefs.GetInt("DEATH_COUNT").ToString();
    }

}
