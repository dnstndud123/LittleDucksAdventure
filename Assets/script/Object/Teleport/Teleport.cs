using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets._2D;

public class Teleport : MonoBehaviour
{
    
    public GameObject telp;
    public Transform fallCam;
    void Update()
    {
        Transform player = Character2D.ins.gameObject.transform;
        if (fallCam == null)
            telp.transform.position = new Vector2(telp.transform.position.x, player.position.y);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {



        if (collision.tag == "Player")
        {

            collision.transform.position = telp.transform.position;
            Vector3 plPos = collision.transform.position;
            if (fallCam == null)
            {
                Camera.main.transform.position = new Vector3(plPos.x, plPos.y, Camera.main.transform.position.z);
            }
        }
    }
}
