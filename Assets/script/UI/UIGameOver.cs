using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIGameOver : UIBase
{
    Button[] btn;
    public override void Init()
    {
        ad.Init();
        btn = GetComponentsInChildren<Button>(true);
        foreach (Button b in btn)
        {
            b.gameObject.SetActive(false);
        }
        
        StartCoroutine(btnActive());
        

        base.Init();
        if (txt != null) txt.text = PlayerPrefs.GetInt("DEATH_COUNT").ToString();
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
