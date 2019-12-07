using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moremoving : MonoBehaviour {
	public float jump;
	public Rigidbody2D youcantdothat;
	public bool groundchecky = false;

	// Use this for initialization
	void Start () {
		youcantdothat = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {


		if (Input.GetKeyDown ("up")) {
			
			youcantdothat.velocity = new Vector2 (youcantdothat.velocity.x,jump);

		}
		if (Input.GetKey("left")&& youcantdothat.velocity.x<12 && youcantdothat.velocity.x>-12) {
			youcantdothat.velocity = new Vector2 (-10, youcantdothat.velocity.y);

		}

		if (Input.GetKey ("right")&& youcantdothat.velocity.x<12 && youcantdothat.velocity.x>-12) {
			youcantdothat.velocity = new Vector2 (10, youcantdothat.velocity.y);
		}



	}
}
