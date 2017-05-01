using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUp : MonoBehaviour {
    public GameObject ground;

	// Use this for initialization
	void Start () {
        if (this.tag == "hidden")
            ground.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
 
	}

    void OnCollisionEnter(Collision other)
    { 
        if(other.collider.tag == "Player")
        {
            while (ground.transform.position.y < 2.9)
                ground.transform.Translate(Vector3.up * Time.deltaTime);

            other.transform.position = ground.transform.position + new Vector3(0, .001f, 0);
            
        }
    }



  
    
}
