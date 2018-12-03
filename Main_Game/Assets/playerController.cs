using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {

	//movment 
	public float speed,jumpForce,moveInput;

	//crashing
	private Rigidbody2D rB;
	private bool grounded;
	public Transform groundCheck;
	//animation
	public Animator animation;




	 
	// Use this for initialization
	void Start () {
		rB = GetComponent <Rigidbody2D> ();
		//animation= GetComponent <> ();
		//jumpButton.onClick.AddListener(Jump);
		//scrollButton.onClick.AddListener(Scroll);

	}
	
	// Update is called once per frame
	void Update () {
		//transform.position = Vector2.MoveTowards (transform.position, new Vector3(3,0,0) , speed * Time.deltaTime);
		if (Input.GetKeyDown(KeyCode.UpArrow)&& grounded)//change it with button listner
		{
			Jump ();
		}
		else if (Input.GetKeyDown(KeyCode.DownArrow))
		{
			Scroll ();
		}
		//if
		/*else if()//less than the center it will come forward alittle bit 
		{
			rigidbody2D.velocity.y = 0;
		}*/

	}

	void Jump(){
		rB.velocity = Vector2.up * jumpForce;
		animation.SetBool ("scrolling", false);
		animation.SetBool ("jumping", true);
		grounded = false;

		//Jump = true;

	}

	void Scroll(){
		animation.SetBool ("jumping", false);
		animation.SetBool ("scrolling", true);

	}
	public void Landing(){
		animation.SetBool ("jumping", false);
		grounded = true;
	}
	void OnCollisionEnter2D(Collision2D other ){


		if(other.gameObject.tag == "obstecale")
		{print("ops");
			//Destroy(col.gameObject);
		}
		else if (other.gameObject.tag=="ground") {
			print("ground");
			Landing ();

			//make it lay on horizintal line
			//	other.GetComponent<Player>().camAnim.SetTrigger("shake");
			//Instantiate(effect, transform.position, Quaternion.identity);
			//game over!
		}   
	}


	private void OnTriggerEnter2D( UnityEngine.Collider2D other)
	{
		if (other.CompareTag("obstecale")) {
			
			print("ops");

			//make it lay on horizintal line
		//	other.GetComponent<Player>().camAnim.SetTrigger("shake");
			//Instantiate(effect, transform.position, Quaternion.identity);
			//game over!
		}   
		if (other.CompareTag("ground")) {
			print("ground");
			Landing ();

			//make it lay on horizintal line
			//	other.GetComponent<Player>().camAnim.SetTrigger("shake");
			//Instantiate(effect, transform.position, Quaternion.identity);
			//game over!
		}   
	}
}
