using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float rotate;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 rot = new Vector3(0, 0, 0);
        transform.rotation = Quaternion.Euler(new Vector3(rot.x, rot.y, rot.z));
        transform.Rotate(0, 0, rotate++);
        if (rotate > 360.0f)
        {
            rotate = 0;
        }
    }
}
