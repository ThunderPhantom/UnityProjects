using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerHealth : MonoBehaviour {
	public int startingHealth = 10;
	public int currentHealth;
	bool isDead;
	bool damaged;
	public Text healthText;
	// Use this for initialization
	void Start () {
		currentHealth = startingHealth;
		healthText.text = "Health: "+ currentHealth.ToString();
	}
	
	// Update is called once per frame
	void Update () {}

	public void takeDamage(int amount) {
		damaged = true;
		currentHealth -= amount;
		healthText.text = "Health: "+ currentHealth.ToString();
	}
}
