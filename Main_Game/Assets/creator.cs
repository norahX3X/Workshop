using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class creator : MonoBehaviour {
	private float timeBtwSpawns;

	public GameObject[] obstacleTemplate;
	public GameObject[] fruits;

	public float speed;
	//public GameObject effect;

	private void Start()
	{
	}

	void Update () {
		transform.Translate(Vector2.left * speed * Time.deltaTime);
		if (timeBtwSpawns <= 0)
		{
			int rand = Random.Range(0, obstacleTemplate.Length);
			Instantiate(obstacleTemplate[rand], transform.position, Quaternion.identity);
			timeBtwSpawns = Random.Range(0.56f, 1.5f);


		}
		else {
			timeBtwSpawns -= Time.deltaTime;
		}
	}
}
