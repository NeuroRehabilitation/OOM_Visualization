using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClouds : MonoBehaviour
{
    public GameObject icon;
    private bool active;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("r"))
        {
            active = !active;
            icon.SetActive(active);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        active = !active;
        icon.SetActive(active);
    }
}
