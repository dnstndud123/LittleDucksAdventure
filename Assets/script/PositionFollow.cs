using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionFollow : MonoBehaviour
{
    [SerializeField] Transform player;

    [SerializeField] float posY = 0;

    public void Init()
    {
        player = GameObject.Find("Player").GetComponent<Transform>();
    }
    void Update()
    {
        
        
        
        posY = player.position.y;
        transform.position = new Vector2(transform.position.x, posY);
    }
}
