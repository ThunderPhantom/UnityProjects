using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour {
    public GameObject Camera;
    public float deathDepth = 40;

    public Object gameOverScreen;
	
	// Update is called once per frame
	private void Update () {
		if (gameObject.transform.position.y < Camera.transform.position.y - deathDepth)
        {
            SceneManager.LoadScene(gameOverScreen.name);
        }
	}
}
