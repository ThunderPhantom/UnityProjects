using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisappearingBlocks : MonoBehaviour {
    public GameObject togglee;
    public float timer = 5f;
	// Use this for initialization
	void Start () {
		
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" && togglee.activeSelf)
        {
            timer = 5f;
            togglee.SetActive(false);
        }
            
    }
    // Update is called once per frame
    void Update () {
		if(timer < 0)
        {
            togglee.SetActive(true);
            
        }
        if(!togglee.activeSelf)
        {
            timer -= Time.deltaTime;
        }
	}
}
