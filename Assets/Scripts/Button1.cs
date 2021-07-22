using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button1 : MonoBehaviour
{

    public Material freeMountain;
    public Texture satellite;

    void OnTriggerEnter(Collider other)
    {
        freeMountain.mainTexture = satellite;
    }
}
