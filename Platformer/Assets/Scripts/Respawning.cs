using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawning : MonoBehaviour {
	private Rigidbody2D rb2d;
	private GameObject Spawner;
	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D> ();

	}

	void OnTriggerEnter2D(Collider2D thing){
		if (thing.tag == "Respawn") {
			Spawner = thing.gameObject;
		}
	}

	// Update is called once per frame
	void Update () {
		if (rb2d.transform.position.y < -10) {
			rb2d.position = Spawner.transform.position;
			rb2d.velocity = new Vector3 (0, 0, 0);
		}
	}
}
