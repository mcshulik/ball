using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class  DangerObject : MonoBehaviour
{
    public Collider Player = null;
	
	private void OnTriggerEnter(Collider other)
	{
		if (other == Player)
		{
            SceneManager.LoadScene("MainMenu");
        }
	}

}
