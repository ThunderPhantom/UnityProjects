using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour {
	private Animator anim;
	// Use this for initialization
	void Start () {
		
		anim = GetComponentInParent<Animator> ();	
	}
	

	void OnTriggerEnter (Collider thing){
		
		if (thing.tag == "Enemy"){
			thing.gameObject.GetComponent<Enemy> ().health -= 1;
			thing.gameObject.GetComponent<EnemyMovement>().knockBack();

		}
	}

	void FixedUpdate () {
		if (Input.GetKeyDown (KeyCode.Mouse0)) {
			anim.SetTrigger ("Schwinging");
		}
	}

}
