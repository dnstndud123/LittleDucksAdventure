using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBackground : MonoBehaviour
{
    public float _speed;
    public float _desPoint;
    public float _oriPoint;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        Vector3  pos = transform.position;
        pos.x += Time.deltaTime * _speed;

        transform.position = new Vector3(pos.x,pos.y,pos.z);

        
        if (transform.position.x > _desPoint)
        {
            transform.position = new Vector3(_oriPoint, pos.y, pos.z);
        }
    }
}
