using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour {

	private Rigidbody rb;
	public float speed;
	private Vector3 respawn;
	private bool isGrounded = false;
	private float size;
	public float jumpSpeed;

	void Start()
	{
		rb = GetComponent<Rigidbody>();
		respawn = transform.position;
		size = GetComponent<SphereCollider> ().bounds.size.y/2f + 0.01f;
	}

	void FixedUpdate()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal * speed, 0.0f, moveVertical * speed);

		rb.AddForce (movement);


		if (Input.GetKeyDown (KeyCode.Space)) {
			
			isGrounded = true;

		}

		if (Physics.Raycast (transform.position, Vector3.down, 1f) && isGrounded) {
			rb.AddForce (Vector3.up * jumpSpeed, ForceMode.Impulse);
		}

		isGrounded = false;

		if (transform.position.y < -100) {
				transform.position = respawn;
				rb.angularVelocity = Vector3.zero;
				rb.velocity = Vector3.zero;
			GameObject.FindGameObjectWithTag ("UIText").GetComponent<Score> ().resetScore();

		}

	}
}
