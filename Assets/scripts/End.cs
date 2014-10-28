using UnityEngine;
using System.Collections;

public class End : MonoBehaviour {

    void OnGUI()
    {
        // Make a background box
        GUI.Box(new Rect(270, 100, 200, 240), "You Died!");

        // Make the first button. If it is pressed, Application.Loadlevel (1) will be executed
        if (GUI.Button(new Rect(325, 160, 100, 40), "Restart"))
        {
            Application.LoadLevel("destroyed_city");
        }

        // Make the second button.
        if (GUI.Button(new Rect(325, 220, 100, 40), "Main Menu"))
        {
            Application.LoadLevel("Main Menu");
        }

        // Make the first button. If it is pressed, Application.Loadlevel (1) will be executed
        if (GUI.Button(new Rect(325, 280, 100, 40), "Exit"))
        {
            Application.Quit ();
        }
    }
}
