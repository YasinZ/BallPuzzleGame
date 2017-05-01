using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockControllerOff : MonoBehaviour {
    public GameObject onBlocks;
    public GameObject offBlocks;

    // Use this for initialization
    void Start () {
        onBlocks = GameObject.FindGameObjectWithTag("WallOn");
        offBlocks = GameObject.FindGameObjectWithTag("WallOff");


    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown(KeyCode.E))
            Change();
    }

    void Change()
    {
        onBlocks.SetActive(false);
        offBlocks.SetActive(true);
    }
}
