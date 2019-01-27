using UnityEngine;
using System.Collections;

public class StartMenu : MonoBehaviour {

    bool menuActive = true;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnGUI()
    {
        if(menuActive)
        {
            GUI.Box(new Rect(10, 10, 200, 180), "Menu");
            if(GUI.Button(new Rect(20,40,160,40), "Start Game"))
            {
                menuActive = false;
                Application.LoadLevel(2);
            }
        }
    }
}
