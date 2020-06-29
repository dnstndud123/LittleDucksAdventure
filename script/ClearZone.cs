using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using JetBrains.Annotations;

public class ClearZone : MonoBehaviour
{
    public int stageNum;
    public AdventurerCharacter2D char2D;
    
    private void OnDrawGizmos()
    {
        Handles.Label(transform.position, "ClearZone");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.name == "player")
        {
            UiManager uiM = FindObjectOfType<UiManager>();
            uiM.HideAll();
            //스테이지 클리어
            uiM.Show("UiLoading", true);

            UiLoading uiLoading = FindObjectOfType<UiLoading>();
            uiLoading.NextStage(stageNum + 1);
            char2D._hp = char2D._hp + 20;
            char2D.UiHp.text = char2D._hp.ToString();
            char2D.atk = char2D.atk + 5;
            
        }

        
    }
}
