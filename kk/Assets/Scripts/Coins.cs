using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coins : MonoBehaviour {
    public static int coins;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter2D(Collider2D collision) //if the player collides with the coin the coin gets destroyed
    {
        if (collision.gameObject.tag == "Player")
        {
            coins++;
            GameObject.Find("CoinText").GetComponent<Text>().text = "Coins: " + coins;
            Destroy(gameObject);
        }

    } 
}
