using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

    public float levelTime;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        levelTime -= Time.deltaTime;
        if(levelTime < 0)
        {
            SceneManager.LoadScene("ShopScene");
        }
	}
}
