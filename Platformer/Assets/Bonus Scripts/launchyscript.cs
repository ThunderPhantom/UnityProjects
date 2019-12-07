using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class launchyscript : MonoBehaviour {
	public Rigidbody2D youcantdothat;
	// Use this for initialization
	void Start () {
		youcantdothat = GetComponent<Rigidbody2D>();
	}
	void OnCollisionEnter2D (Collision2D CocaCola) {
		if (CocaCola.gameObject.tag == "Player") {
			CocaCola.gameObject.GetComponent <Rigidbody2D> ().AddForce (new Vector2 (5000, 2));
		}
	}
	// Update is called once per frame
	void Update () {
		
	}
}
