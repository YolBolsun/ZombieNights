using UnityEngine;
using System.Collections;

public class HUD : MonoBehaviour {

    public GameObject homeBase;
    public GUIStyle style;
    public GUIStyle styleBackground;
    public GameObject levelManager;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnGUI()
    {
        GUI.Box(new Rect(10, 10, 400, 180), "Menu",styleBackground);
        GUI.Label(new Rect(20, 40, 160, 40), new GUIContent("Health: "+homeBase.GetComponent<HomeBase>().healthRemaining.ToString()), style);
        GUI.Label(new Rect(20, 100, 160, 40), new GUIContent("Time Remaining: " + Mathf.Ceil(levelManager.GetComponent<LevelManager>().levelTime)/*TODO add timer*/), style);
        GUI.Label(new Rect(20, 160, 160, 40), new GUIContent("Gold: " + homeBase.GetComponent<HomeBase>().gold),style);
    }
}
