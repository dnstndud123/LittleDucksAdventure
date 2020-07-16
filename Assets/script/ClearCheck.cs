using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearCheck : MonoBehaviour
{
    public int stageNumber;
    public Character2D char2D;
    public UIManager uM;
    SoundManager sM;
     GameObject clearCheck;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        sM = FindObjectOfType<SoundManager>();
        char2D = FindObjectOfType<Character2D>();
        uM = FindObjectOfType<UIManager>();
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "Player")
        {
            sM.Play("Score");
            uM.HideAll();
            uM.Show("UISelect", uM.uiList[1]);
            player.tag = "ClearPlayer";
            clearCheck.SetActive(false);
            
                



        }

#if UNITY_ANDROID||UNITY_IOS
#endif
    }

}
