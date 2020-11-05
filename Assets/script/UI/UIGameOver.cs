using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIGameOver : UIBase
{
    public AdBanner ad;
    public override void Init()
    {   
        ad = GetComponentInChildren<AdBanner>(true);
        ad.Init();
        base.Init();
        
        if (txt != null) txt.text = PlayerPrefs.GetInt("DEATH_COUNT").ToString();
    }
    
}
