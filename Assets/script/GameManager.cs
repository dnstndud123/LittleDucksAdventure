using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets._2D;

public class GameManager : MonoBehaviour
{
    //public GameObject startSpawn;
    public GameObject player;
    Camera2DFollow camFollow;
    public GameObject clearSpawn;
    public GameObject clear;
    [SerializeField] private int currentPoint;



    public void Init(GameObject player)
    {

        camFollow = FindObjectOfType<Camera2DFollow>();

        clearSpawn = GameObject.Find("clearSpawn");
        clear = GameObject.Find("clear");
        ClearRespawn();

        PositionFollow[] positionFollow = GetComponentsInChildren<PositionFollow>();
        foreach (PositionFollow p in positionFollow)
        {
            p.Init();
        }
        this.player = player;
        
        if (camFollow != null)
        {
            Vector3 charPosition = player.transform.position;
            player.transform.position = new Vector3(charPosition.x, charPosition.y, charPosition.z);
        }
        
        

    }
   /* public  void NextStage(int stageNumber)
    {
        //GameObject startPoint = startSpawn[stageNumber - 1];
        
        Vector2 startPosition = startSpawn.transform.position;
        Vector3 charPosition = player.transform.position;
        player.transform.position = new Vector3(startPosition.x, startPosition.y,charPosition.z);
        player.tag = "Player";


        camFollow.transform.position = new Vector3(player.transform.position.x, player.transform.position.y,-10);
        camFollow.target = player.transform;
    }
   */
    public void ClearRespawn()
    {
        //GameObject respawnPoint = clearSpawn[stageNumber - 1];
        Vector2 respawnPosition = clearSpawn.transform.position;
        clear.transform.position = new Vector2(respawnPosition.x, respawnPosition.y);
    }
}
