using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallGenerator : MonoBehaviour
{
	[SerializeField] GameObject Wall;
	[SerializeField] float CreationTimeDelta;
	float TimeToCreate;
    // Start is called before the first frame update
    void Start()
    {
		  TimeToCreate = CreationTimeDelta;
    }

    // Update is called once per frame
    void Update()
    {
		TimeToCreate -= Time.deltaTime;
		if (TimeToCreate <= 0) 
		{
			TimeToCreate += CreationTimeDelta;
			GameObject copy = Object.Instantiate(Wall);
			copy.GetComponent<Cube>().IsCopy = true;

		} 
    }
}
