using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BtnUI : MonoBehaviour
{ 

    [HideInInspector]
    static BtnUI instance;
    public static BtnUI ins
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<BtnUI>();
                if (null == instance)
                {
                    Debug.LogError("BtnUi 인스턴스 가져오기 실패");

                }

            }
            return instance;
        }
    }

    public Button[] btns;

    public void Update()
    {


        
        
    }
    public void MoveButton(Button btn)
    {
        if (btn.name == "Left")
        {
            
            PlayerControl.ins.LeftMove();
        }
        if (btn.name == "Right")
        {
            PlayerControl.ins.RightMove();
        }

        
    }

    
    public void JumpButton()
    {
        Character2D.ins.Jump();
    }
}
