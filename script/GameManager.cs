using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] startList;
    public GameObject player;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    
    // Update is called once per frame
    void Update()
    {
        
    }
    public void NextStage(int stageNumber)
    {
        GameObject srtP = startList[stageNumber - 1];

        Vector2 srtPos = srtP.transform.position;
        player.transform.position = new Vector2(srtPos.x, srtPos.y);
    }
}
