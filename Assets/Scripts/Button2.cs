using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button2 : MonoBehaviour
{
    public Material freeMountain;
    public Texture color;

	// Update is called once per frame
	void Update () {
		if (Input.GetKey("w"))
		{
			freeMountain.mainTexture = color;
			ButtonLeft3.bt3onflag = false;
		}
	}
		
    void OnTriggerEnter(Collider other)
    {
        freeMountain.mainTexture = color;
		ButtonLeft3.bt3onflag = false;
	}
}
