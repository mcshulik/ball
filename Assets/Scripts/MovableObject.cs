﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovableObject : MonoBehaviour
{
	public bool IsCopy = false;
	public float speed = 0;
    // Start is called before the first frame update
    void Start()
    {
		  
    }

    // Update is called once per frame
    void Update()
    {
		if (IsCopy) 
		{
			Vector3 newposition = new Vector3(transform.position.x, transform.position.y, transform.position.z - speed*Time.deltaTime);
			transform.position = newposition;
		}
    }
	
}
