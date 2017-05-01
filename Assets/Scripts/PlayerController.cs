using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
    private bool canMove = false;
    public float speed;
    public GameState gameState;

    private Rigidbody rb;

    void Start ()
    {
        GetComponent<Renderer>().material.color = gameState.playerColor;
        rb = GetComponent<Rigidbody>();
    }

    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Ground")
        {
            canMove = true;
        }
    }

    void FixedUpdate()
    {
        if (canMove)
        {
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");

            Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

            rb.AddForce(movement * speed);
        }
    }

}
