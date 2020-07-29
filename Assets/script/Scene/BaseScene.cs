using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseScene : MonoBehaviour
{
    public GameObject player;
    public GameObject startP;
    
    // Start is called before the first frame update

    private void Start()
    {
        Init();
    }
    public virtual void Init()
    {
        GameObject player = GameObject.Find("Player");
        startP = GameObject.Find("StartPoint");

        if (player == null)
        {
            GameObject p = Instantiate(this.player);
            p.name = "Player";
            player = p;
        }
        Character2D chr = player.GetComponent<Character2D>();
        chr.Init();

        Vector3 startPos = startP.transform.position;
        player.transform.position = new Vector3(startPos.x, startPos.y, startPos.z);
    }

    
}
