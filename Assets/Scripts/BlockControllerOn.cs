using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockControllerOn : MonoBehaviour {
    public GameObject onBlocks;
    public GameObject offBlocks;
    bool first = true;

    // Use this for initialization
    void Start () {
        onBlocks = GameObject.FindGameObjectWithTag("WallOn");
        offBlocks = GameObject.FindGameObjectWithTag("WallOff");

    }
	
	// Update is called once per framex
	void Update () {
        if (first)
        {
            offBlocks.active = false;
            first = false;
        }
        if (Input.GetKeyDown(KeyCode.Space))
            Change();
		
	}

    void Change()
    {
        onBlocks.SetActive(!onBlocks.activeSelf);
        offBlocks.SetActive(!offBlocks.activeSelf);
    }
}
