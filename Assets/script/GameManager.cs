using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets._2D;

public class GameManager : MonoBehaviour
{
    public GameObject[] startList;
    public GameObject player;
    Camera2DFollow camFollow;
    public GameObject[] clearList;
    public GameObject clear;
    [SerializeField] private int currentPoint;


    private void Start()
    {
        camFollow = FindObjectOfType<Camera2DFollow>();
        
        Vector3 charPosition = player.transform.position;
        player.transform.position = new Vector3(charPosition.x, charPosition.y, charPosition.z);
    }
    public  void NextStage(int stageNumber)
    {
        GameObject startPoint = startList[stageNumber - 1];
        
        Vector2 startPosition = startPoint.transform.position;
        Vector3 charPosition = player.transform.position;
        player.transform.position = new Vector3(startPosition.x, startPosition.y,charPosition.z);
        player.tag = "Player";


        camFollow.transform.position = new Vector3(player.transform.position.x, player.transform.position.y,-10);
        camFollow.target = player.transform;
    }
    public void ClearRespawn(int stageNumber)
    {
        GameObject respawnPoint = clearList[stageNumber - 1];
        Vector2 respawnPosition = respawnPoint.transform.position;
        clear.transform.position = new Vector2(respawnPosition.x, respawnPosition.y);
    }
}
