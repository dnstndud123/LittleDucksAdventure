using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIGameOver : MonoBehaviour
{
    UIManager uM;
    // Start is called before the first frame update
    void Start()
    {
        uM = FindObjectOfType<UIManager>();
    }

    public void OnSelect()
    {
        uM.HideAll();
        uM.Show("UISelect", uM.uiList[1]);
    }
}
