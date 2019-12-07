using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {
	public Rigidbody rb;
	public float knockbackPower;
	public GameObject player;

	void Start () {
		rb = GetComponent<Rigidbody> ();
		player = GameObject.FindGameObjectWithTag("Player");
	}

	private Vector3 directionToPlayer(){
		Vector3 offset = -transform.position + player.transform.position;
		offset.Normalize ();
		offset = new Vector3 (offset.x, 0.01f, offset.z);
		return offset;
	}

	public void knockBack(){
		Vector3 awayFromPlayer = (directionToPlayer());
		awayFromPlayer = new Vector3(-awayFromPlayer.x, 1 ,-awayFromPlayer.z);
		rb.AddForce (awayFromPlayer * 2500);

	}

	public bool groundCheck(){
		if (Physics.Raycast (transform.position, Vector3.down, gameObject.GetComponent<BoxCollider>().size.y/20f) ){
			return true;

		}else{
			return false;
		}

	}

	// Update is called once per frame
	void FixedUpdate () {
		Vector3 dir = directionToPlayer ();
		if (groundCheck()){
			rb.velocity = dir;

		}


		transform.LookAt (player.transform.position);

	}
		

}
