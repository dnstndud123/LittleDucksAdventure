using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class StartPoint : MonoBehaviour
{
    private void OnDrawGizmos()
    {
        Handles.Label(transform.position, "StartPoint");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "StartPoint")
        {
            UiManager uiM = FindObjectOfType<UiManager>();
            uiM.HideAll();
            
            uiM.Show("UiStart", true);
        }
    }
}
