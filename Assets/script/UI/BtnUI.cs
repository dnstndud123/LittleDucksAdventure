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

    //public Button[] btns;

    bool _isMoving = false;
    Button _pressedBtn = null;
    Button _jump = null;
    public void Update()
    {
        if (_isMoving)
            MoveButton(_pressedBtn);

    }

    public void OnButtonDown(Button btn)
    {
        _isMoving = true;
        _pressedBtn = btn;
    }

    public void OnButtonUp(Button btn)
    {
        _isMoving = false;
        _pressedBtn = null; 
    }

    public void MoveButton(Button btn)
    {
        if (btn.name == "Left")
        {

            PlayerControl.ins.LeftMove(true);
        }
        if (btn.name == "Right")
        {
            PlayerControl.ins.RightMove(true);
        }

        
    }
    

    
    public void JumpButtonDown(Button btn)
    {
        Character2D.ins.Jump();
        StartCoroutine(PlayerControl.ins.JumpCheckEnabled());
        _jump = btn;
    }
    public void JumpButtonUp(Button btn)
    {
        _jump = null;
    }
}
