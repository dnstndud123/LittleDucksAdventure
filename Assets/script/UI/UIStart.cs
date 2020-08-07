using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIStart : UIBase
{

   
    
       
    
    public override void OnButtonClick(GameObject btn)
    {
        sM.Play("Select");
        StartCoroutine(OnPlay(btn.name));
            
    }
}
