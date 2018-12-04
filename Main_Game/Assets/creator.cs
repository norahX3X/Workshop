using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class creator : MonoBehaviour {
	private float timeBSpawns,timeBtwfruits;

	public GameObject[] obstacleTemplate;
	public GameObject[] fruits;
	public GameObject ground;

	public float speed;
	//public GameObject effect;

	private void Start()
	{
		
	}

	void Update () {
		//transform.Translate(Vector2.left * speed * Time.deltaTime);
		if (timeBSpawns <= 0)
		{
			int rand = Random.Range(0, obstacleTemplate.Length);
			if(rand < 3) 
				Instantiate(obstacleTemplate[rand],new Vector3(transform.position.x,ground.transform.position.y+0.9f,transform.position.z), Quaternion.identity);
			else
				Instantiate(obstacleTemplate[rand], new Vector3(transform.position.x,ground.transform.position.y+2f,transform.position.z), Quaternion.identity);
			
			timeBSpawns = Random.Range(1f, 3f);

		}
		else {
			timeBSpawns -= Time.deltaTime;
		}


		if (timeBtwfruits <= 0)
		{
			int rand = Random.Range(0, fruits.Length);
			Instantiate(fruits[rand], new Vector3(transform.position.x,ground.transform.position.y+3.5f,transform.position.z), Quaternion.identity);
	
			timeBtwfruits = Random.Range(0.56f, 1.5f);

		}
		else {
			timeBtwfruits -= Time.deltaTime;
		} 







	}
}
