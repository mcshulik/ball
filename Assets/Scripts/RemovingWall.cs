using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class  RemovingWall : MonoBehaviour
{
    public Collider Player = null;
	
	private void OnTriggerEnter(Collider other)
	{

		Destroy(other);	
		
	}
}
