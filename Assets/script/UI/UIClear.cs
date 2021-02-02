using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
public class UIClear : UIBase
{
    Button[] btn;
    public override void Init()
    {
        ad.Init();
        //ad = GetComponentInChildren<AdBanner>(true);
        btn = GetComponentsInChildren<Button>(true);
        foreach (Button b in btn)
        {
            b.gameObject.SetActive(false);
        }
        
        StartCoroutine(btnActive());
        
        base.Init();
    }

    public IEnumerator btnActive()
    {
        yield return new WaitForSeconds(3);
        if (btn != null)
        {
            foreach (Button b in btn)
            {
                b.gameObject.SetActive(true);
            }
        }
    }





}
