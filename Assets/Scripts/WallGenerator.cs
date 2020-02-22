using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallGenerator : MonoBehaviour
{
	[SerializeField] GameObject Wall = null;
	[SerializeField] float CreationTimeDelta = 0;
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
			Vector3 position = new Vector3(Wall.transform.position.x, Random.Range(1.7f, 4.9f), Wall.transform.position.z);
			GameObject copy = Object.Instantiate(Wall, position, Wall.transform.rotation);
			copy.GetComponent<MovableObject>().IsCopy = true;

		} 
    }
}
