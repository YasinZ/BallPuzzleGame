using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {
    public Transform transform;
    public GameState gameState;
    public float speed = 10f;

    private bool goingDown = true;

    // Use this for initialization
    void Start () {
        GetComponent<Renderer>().material.color = gameState.playerColor;
    }

    // Update is called once per frame
    void Update()
    {

        if (transform.position.y > -1f && goingDown)
            transform.Translate(Vector3.down * Time.deltaTime * speed);
        else
            goingDown = false;

        if (transform.position.y < 5f && !goingDown)
            transform.Translate(Vector3.up * Time.deltaTime * speed);
        else
            goingDown = true;


    }


}
