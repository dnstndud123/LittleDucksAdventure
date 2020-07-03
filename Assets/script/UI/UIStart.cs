using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIStart : UIBase
{
    public override void OnButtonClick(GameObject btn)
    {
        base.OnButtonClick(btn);
        sM.Play("Select");
    }
}
