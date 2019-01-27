using UnityEngine;
using System.Collections;

public class ShopManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnGUI()
    {
        GUI.Box(new Rect(10, 10, Screen.width-20, Screen.height-20), "You Got To the SHOP temp gj");
        if (GUI.Button(new Rect(20, 40, 160, 40), "Restart"))
        {
            Application.LoadLevel(2);
        }
    }
}
