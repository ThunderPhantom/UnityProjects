using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour {

	public float speed;             //Floating point variable to store the player's movement speed.
	public float jump;
	public bool touching = false;
	public float offset;
	public CharacterController you;
	public float tester;
	private Rigidbody2D rb2d;      
	public bool groundchecky;
	public int doublejump = 1;
	// Use this for initialization
	void Start()
	{
		//Get and store a reference to the Rigidbody2D component so that we can access it.
		rb2d = GetComponent<Rigidbody2D> ();


	}

	void OnCollisionEnter2D(Collision2D other){
		
		if (other.collider.tag == "Platform"){	
			touching = true;	
			offset = transform.position.y - other.collider.transform.position.y;
		}


	}

	void OnCollisionStay2D(Collision2D other){
		if (other.collider.tag == "Platform" && touching ) {
				transform.position = new Vector3 (transform.position.x, other.collider.transform.position.y + offset, transform.position.z);
				rb2d.velocity = other.rigidbody.velocity;
				
			if (Input.GetKeyDown ("up")) {
				touching = false;
				transform.position = new Vector3 (transform.position.x, other.collider.transform.position.y + offset+.2f, transform.position.z);
				rb2d.velocity = new Vector3 (rb2d.velocity.x, jump, 0);
			}
		}
	}




	//FixedUpdate is called at a fixed interval and is independent of frame rate. Put physics code here.
	void FixedUpdate()
	{
		float moveHorizontal=0;

		if (groundchecky) {
			doublejump = 1;

		} else {
			moveHorizontal = rb2d.velocity.x;
		}

		if (Input.GetKey ("left")) {
			moveHorizontal = -15;
		} else if (Input.GetKey ("right")) {
			moveHorizontal = 15;
		} else if (groundchecky) {
			moveHorizontal = 0;
		}
		if (Input.GetKeyDown ("up") && doublejump > 0 ) {
			rb2d.velocity = new Vector2 (rb2d.velocity.x, jump);
			doublejump -= 1;

		} 



		//Call the AddForce function of our Rigidbody2D rb2d supplying movement multiplied by speed to move our player.
		rb2d.velocity = new Vector2(moveHorizontal,rb2d.velocity.y);
	}

}
