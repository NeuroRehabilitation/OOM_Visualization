﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour {

	float speed = 5.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        /*if (Input.GetAxis("Mouse X") > 0) 
        {
			transform.position += new Vector3(Input.GetAxisRaw("Mouse X") * Time.deltaTime * speed,
				0.0f, Input.GetAxisRaw("Mouse Y") * Time.deltaTime * speed);
        }
		else if (Input.GetAxis("Mouse X") > 0)
        {
			transform.position += new Vector3(Input.GetAxisRaw("Mouse X") * Time.deltaTime * speed,
				0.0f, Input.GetAxisRaw("Mouse Y") * Time.deltaTime * speed);
		}*/
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(new Vector3(-speed * Time.deltaTime, 0, 0));
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(new Vector3(0, -speed * Time.deltaTime, 0));
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(new Vector3(0, speed * Time.deltaTime, 0));
        }
        if (Input.GetKey("o"))
        {
            transform.Translate(new Vector3(0, 0, speed * Time.deltaTime));
        }
        if (Input.GetKey("l"))
        {
            transform.Translate(new Vector3(0, 0, -speed * Time.deltaTime));
        }
    }
}
