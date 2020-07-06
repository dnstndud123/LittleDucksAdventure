using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIGameOver : UIBase
{


    public void OnSelect()
    {
        uM.HideAll();
        uM.Show("UISelect", uM.uiList[1]);
    }
}
