using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour {
    public GameObject specialNeutral;


    public virtual void special(float direction)
    {
     
        


    }




	// Use this for initialization
	void Start () {
		


	}


	// Update is called once per frame
	public void Update () {
        if (Input.GetKeyDown(KeyCode.B))
        {
            special(Input.GetAxis("Horizontal"));
        }

    }
}
