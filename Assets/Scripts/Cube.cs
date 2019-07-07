using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
	public bool IsCopy = false;
    // Start is called before the first frame update
    void Start()
    {
		  
    }

    // Update is called once per frame
    void Update()
    {
	
		if (IsCopy) 
		{
			GetComponent<Rigidbody>().velocity = new Vector3(0, 0, -1);
		}
    }
	private void OnTriggerEnter(Collider other)
	{
		print("Game over");
	}
}
