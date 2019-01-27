using UnityEngine;
using System.Collections;

public class HomeBase : MonoBehaviour {

    public int healthRemaining;
    public int gold = 0;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void TakeDamage(int damage)
    {
        healthRemaining -= damage;
        if(healthRemaining < 0)
        {
            healthRemaining = 0;
        }
        Debug.Log(healthRemaining);
        if(healthRemaining == 0)
        {
            //TODO loss stuff
            Application.LoadLevel(1);
            Debug.Log("You Lose");
        }
        //TODO display text about remaining health
    }
}
