using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GUITest : MonoBehaviour {
    private int startPos = 1800;

    void OnGUI()
    {
        // Make a background box
        GUI.Box(new Rect(startPos, 10, 100, 145), "Level Select");

        // Make the first button. If it is pressed, Application.Loadlevel (1) will be executed
        if (GUI.Button(new Rect(startPos + 10, 40, 80, 20), "Level 1"))
        {
            SceneManager.LoadScene(1);
        }

        // Make the second button.
        if (GUI.Button(new Rect(startPos + 10, 70, 80, 20), "Level 2"))
        {
            SceneManager.LoadScene(2);
        }

        // Make the second button.
        if (GUI.Button(new Rect(startPos + 10, 100, 80, 20), "Level 3"))
        {
            SceneManager.LoadScene(3);
        }

        // Make the second button.
        if (GUI.Button(new Rect(startPos + 10, 130, 80, 20), "Level 4"))
        {
            SceneManager.LoadScene(4);
        }
    }
}
