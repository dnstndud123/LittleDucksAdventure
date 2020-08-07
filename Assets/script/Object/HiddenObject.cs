﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HiddenObject : MonoBehaviour
{
    public GameObject obj;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "JumpCheck")
        {
            obj.SetActive(true);
        }
    }

}