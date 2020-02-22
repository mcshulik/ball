using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class  DangerObject : MonoBehaviour
{
    public Collider Player = null;
	
	private void OnTriggerEnter(Collider other)
	{
		if (other == Player)
		{
			print("Game over");	
		}
	}

}
