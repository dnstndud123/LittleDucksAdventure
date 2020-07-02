using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearCheck : MonoBehaviour
{
    public int stageNumber;
    public Character2D char2D;
    public UIManager uM;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
        char2D = FindObjectOfType<Character2D>();
        uM = FindObjectOfType<UIManager>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            uM.HideAll();
            uM.Show("UISelect", uM.uiList[1]);
            char2D.hp = char2D.maxHp;
            
            
            
        }
    }

}
