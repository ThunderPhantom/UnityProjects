using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MichaelisTrash : MonoBehaviour {

	public Rigidbody2D somethingelse;
	public GameObject iknow;
	// Use this for initialization
	void Start () {
		somethingelse = GetComponent<Rigidbody2D>();
		iknow = GameObject.FindGameObjectWithTag ("Respawn");
	}

	
	// Update is called once per frame
	void Update () {
		if (transform.position.y <-25) {
			transform.position = iknow.transform.position;
			somethingelse.velocity = new Vector2 (0, 0);
		}
		/*if (transform.position.y > 180) {
			transform.position = iknow.transform.position;
			somethingelse.velocity = new Vector2 (0, 0);
		}*/
	}
}
