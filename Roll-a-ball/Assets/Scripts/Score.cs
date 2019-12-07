using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Score : MonoBehaviour {
	public static int score;
	// Use this for initialization
	Text text;
	void Start () {
		gameObject.GetComponent<UnityEngine.UI.Text> ().text = "Score = 0";
		text = GetComponent<Text> ();
		score = 0;
	}

	public void increaseScore(int changeScoreBy){
		score += changeScoreBy;
		gameObject.GetComponent<UnityEngine.UI.Text>().text = "Score: " + score.ToString();
	}

	public void resetScore(){
		score = 0;
		gameObject.GetComponent<UnityEngine.UI.Text>().text = "Score: " + score.ToString();
	}

	// Update is called once per frame
	void Update () {
		text.text = "Score: " + score;
	}
}
