using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClouds : MonoBehaviour
{
    public GameObject icon;
    private bool active;

    void OnTriggerEnter(Collider other)
    {
        active = !active;
        icon.SetActive(active);
    }
}
