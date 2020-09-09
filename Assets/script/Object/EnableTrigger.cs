
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableTrigger : MonoBehaviour
{
    public MoveTrap mT;
    // Start is called before the first frame update
    void Start()
    {
        mT.enabled = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        mT.enabled = true;
    }
}
