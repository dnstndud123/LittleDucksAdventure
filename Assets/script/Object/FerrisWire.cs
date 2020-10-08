using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FerrisWire : MonoBehaviour
{
    
    
    void Update()
    {
        SpriteRenderer p = GetComponent<SpriteRenderer>();
        SpriteRenderer[] sp = GetComponentsInChildren<SpriteRenderer>();
        foreach (SpriteRenderer s in sp)
        {
            s.color = p.color;
        }
    }
}
