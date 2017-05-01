using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
    public GameState gameState;

	void Update () {
		
		if (Input.GetKeyDown(KeyCode.Escape)) {
			SceneManager.LoadSceneAsync ("Homescreen");
		}

		if (Input.GetKeyDown(KeyCode.Backspace)) {
			SceneManager.LoadSceneAsync (SceneManager.GetActiveScene().name);
		}
	}
}
