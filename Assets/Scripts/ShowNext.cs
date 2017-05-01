using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowNext : MonoBehaviour {
    public GameObject room;
    public GameObject wall;
	// Use this for initialization
	void Start () {
        room.SetActive(false);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision collider)
    {
        room.SetActive(true);
        wall.SetActive(false);
    }
}
