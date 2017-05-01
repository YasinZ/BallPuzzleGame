using UnityEngine;
using System.Collections;

public class DoorController : MonoBehaviour {
    private bool open = false;
    private int counter = 0;

    public Transform door;

    void Start()
    {
       
    }

    void OnCollisionEnter(Collision other)
    { 
        open = true;
        door = GameObject.FindWithTag("Door").transform;

    }

    void Update()
    { 
        if (open)
        {
            door.transform.Translate(Vector3.down * Time.deltaTime);
            counter++;
        }

        if(counter == 133)
        {
            open = false;
            counter = 0;
        }
    }
}
