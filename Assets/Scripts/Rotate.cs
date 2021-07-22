using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    private UDPReceive receiver;

    // Use this for initialization
    void Start ()
    {
        receiver = gameObject.GetComponent<UDPReceive>();

    }
	
	// Update is called once per frame
	void Update ()
	{
	    ApplyRotation();

	}

    void ApplyRotation()
    {
        gameObject.transform.localRotation= receiver.Rotation;
    }
}

