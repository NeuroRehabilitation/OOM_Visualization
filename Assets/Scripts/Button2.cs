using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button2 : MonoBehaviour
{
    public Material freeMountain;
    public Texture color;

    void OnTriggerEnter(Collider other)
    {
        freeMountain.mainTexture = color;
    }
}
