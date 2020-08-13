using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float rotate;
    public float speed = 1;
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        Vector3 rot = new Vector3(0, 0, 0);
        transform.rotation = Quaternion.Euler(new Vector3(rot.x, rot.y, rot.z));
        transform.Rotate(0, 0, speed * rotate++);
        if (rotate > 360.0f / speed)
        {
            rotate = 0;
        }
    }
}
