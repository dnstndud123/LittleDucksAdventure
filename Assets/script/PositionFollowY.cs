using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets._2D;

public class PositionFollowY : MonoBehaviour
{
    
    [SerializeField] Transform player;
    [SerializeField] Transform leftCam;
    [SerializeField] Transform rightCam;
    [SerializeField] float posX = 0;

    public void Init()
    {
       
        player = GameObject.Find("Player").GetComponent<Transform>();
        leftCam = GameObject.Find("leftCamWall").GetComponent<Transform>();
        rightCam = GameObject.Find("rightCamWall").GetComponent<Transform>();
    }
    void Update()
    {

       

        if (player.position.x >= leftCam.position.x && player.position.x <= rightCam.position.x)
        {
            posX = player.position.x;
            
        }
        else if (player.position.x < leftCam.position.x)
        {
            posX = leftCam.position.x;
            
        }
        else if (player.position.x > rightCam.position.x)
        {
            posX = rightCam.position.x;
            
        }
        transform.position = new Vector2(posX, transform.position.y);
    }
}
