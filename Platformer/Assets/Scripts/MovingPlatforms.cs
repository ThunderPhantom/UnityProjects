using System.Collections;
using System.Collections.Generic;
using UnityEngine;

	
public class MovingPlatforms : MonoBehaviour {
	private Rigidbody2D rb2d;
	private float high;
	private float low;
	private bool goingUp = true;
	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D> ();
		high = rb2d.transform.position.y + 5;
		low = rb2d.transform.position.y - 5;
	}
	
	// Update is called once per frame
	void Update () {
		if (goingUp) {
			rb2d.velocity = new Vector3 (0, 3, 0);
		} else { 
			rb2d.velocity = new Vector3 (0, -3, 0);
		}
		if (transform.position.y > high) {
			goingUp = false;
		}
		if (transform.position.y < low) {
			goingUp = true;
		}
	}
}
