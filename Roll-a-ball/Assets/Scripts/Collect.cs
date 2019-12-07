using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	void OnTriggerEnter(Collider thing){
		GameObject.FindGameObjectWithTag ("UIText").GetComponent<Score> ().increaseScore (10);
		Destroy (gameObject);
	}

	// Update is called once per frame
	void Update () {
		transform.Rotate (new Vector3(1,1,-1), Time.deltaTime * -75f);
	}
}
