using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IVMove : MonoBehaviour
{
    public float speed;
    public float desPoint;
    public float oriPoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;
        pos.x += Time.deltaTime * speed;

        transform.position = new Vector2(pos.x, pos.y);
        if (pos.x > desPoint)
        {
            transform.position = new Vector2(oriPoint, pos.y);
        }
    }
}
