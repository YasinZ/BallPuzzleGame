using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour {
    public GameObject camera;
    bool moveLeft = true;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if (moveLeft)
        {
            camera.transform.Translate(-15, 0, 0);
            moveLeft = false;
        }
        else
        {
            camera.transform.Translate(15, 0, 0);
            moveLeft = true;
        }
    }
}
