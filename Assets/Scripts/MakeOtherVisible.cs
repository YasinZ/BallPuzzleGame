using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeOtherVisible : MonoBehaviour {
    public GameObject object1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision other)
    {
        if (other.collider.tag == "Player")
        {
            object1.SetActive(true);
        }
    }
} 
