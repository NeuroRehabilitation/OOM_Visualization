using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button1 : MonoBehaviour
{
    public Material freeMountain;
    public Texture satellite;

	// Update is called once per frame
	void Update () {
		if (Input.GetKey("q"))
		{
			freeMountain.mainTexture = satellite;
		}
	}

    void OnTriggerEnter(Collider other)
    {
        freeMountain.mainTexture = satellite;
	}
}
