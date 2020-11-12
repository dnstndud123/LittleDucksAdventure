using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class UIClear : UIBase
{
    public override void Init()
    {
        ad = GetComponentInChildren<AdBanner>(true);
        ad.Init();
        base.Init();
    }





}
