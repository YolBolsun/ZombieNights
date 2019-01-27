using UnityEngine;
using System.Collections;

public class LossMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        
	}
    void OnGUI()
    {
        GUI.Box(new Rect(10, 10, 200, 180), "You Lose");
        if (GUI.Button(new Rect(20, 40, 160, 40), "Restart"))
        {
            Application.LoadLevel(2);
        }
    }
}
