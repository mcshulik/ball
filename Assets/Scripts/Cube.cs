﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
		  
    }

    // Update is called once per frame
    void Update()
    {
	
        {
            GetComponent<Rigidbody>().velocity = new Vector3(0, 0, -1);
        }
    }
}
