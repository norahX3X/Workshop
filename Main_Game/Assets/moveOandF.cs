using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveOandF : MonoBehaviour {


	
	public float speed;
	//public GameObject effect;

	void Update () {
		//movment 
		transform.Translate(Vector2.left * speed * Time.deltaTime);
		//destroy to clean up 
		if(transform.position.x< -20f){
			Destroy(gameObject);
		}
	}
}
