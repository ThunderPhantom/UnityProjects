using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class otherlaunchyscript : MonoBehaviour {
	public Rigidbody2D hi;
	// Use this for initialization
	void Start () {
		hi = GetComponent<Rigidbody2D>();
	}
	void OnCollisionEnter2D (Collision2D Coke) {
		if (Coke.gameObject.tag == "Player") {
			Coke.gameObject.GetComponent <Rigidbody2D> ().AddForce (new Vector2 (2,3000));
		}
	}
	// Update is called once per frame
	void Update () {

	}
}
