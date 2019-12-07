using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreHandler : MonoBehaviour {
    int score = 0;
    float height = 0;
    int scoreMultiplier = 1;

    public GameObject player;

    int scoreCalculator()
    {
        int scoreToAdd = (int) (player.transform.position.y - height);
        return score + (scoreToAdd * scoreMultiplier);
    }


	// Update is called once per frame
	void Update () {
        if (player.transform.position.y > height + 1)
        {
            score = scoreCalculator();
            height = player.transform.position.y;

            Text scoreUI = GetComponent<Text>();
            string toDisplay = "Score:" + score.ToString();
            scoreUI.text = toDisplay;

        }

    }
}