using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChangeController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider collider)
    {
        SceneManager.LoadScene(Application.loadedLevel + 1);
    }

    void OnMouseDown()
    {
        SceneManager.LoadScene(Application.loadedLevel + 1);
    }
}
