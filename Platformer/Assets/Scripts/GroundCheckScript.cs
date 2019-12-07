using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheckScript : MonoBehaviour {
	public BoxCollider2D groundbox;
	public bool test;
	// Use this for initialization
	void Start () {
		groundbox = GetComponent <BoxCollider2D> ();
	}

	void OnTriggerEnter2D (Collider2D other) {
		GetComponentInParent <Moving> ().groundchecky = true;
		test = true;
	}

	void OnTriggerExit2D (Collider2D other) {
		GetComponentInParent <Moving> ().groundchecky = false;
		test = false;
	}

	// Update is called once per frame
	void Update () {
		
	}
}
