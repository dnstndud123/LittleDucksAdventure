using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIGameOver : UIBase
{

    public void OnSelect()
    {
        
        sM.Play("Select");
        StartCoroutine(OnPlay("LevelSelect"));
        
    }
}
