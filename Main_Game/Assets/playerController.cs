using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {

	public float speed,jumpForce,moveInput;
	private Rigidbody2D rB;

	private bool grounded;
	public Transform groundCheck;


	 
	// Use this for initialization
	void Start () {
		rB = GetComponent <Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void Jump(){

	}

	void Scroll(){

	}
}
