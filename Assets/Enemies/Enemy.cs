using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

    public Transform target;
    public int damage;
    public float health;
    public int gold;
    public GameObject homeBase;

    public float moveSpeed;
    Vector3 velocity = new Vector3();
	// Use this for initialization
	void Start () {
        homeBase = GameObject.FindGameObjectWithTag("HomeBase");
	}
	
	// Update is called once per frame
	void Update () {
        Move();
	}
    public void Move()
    {
        //velocity += ((target.position - this.transform.position).normalized * acceleration);
        velocity = ((target.position - this.transform.position).normalized * moveSpeed);
        transform.Translate(velocity * Time.deltaTime);
    }
    void OnCollisionEnter(Collision coll)
    {
        if(coll.collider.CompareTag("HomeBase"))
        {
            coll.collider.GetComponent<HomeBase>().TakeDamage(damage);
            GameObject.Destroy(this.gameObject);
        }
        
    }
    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health < 0)
        {
            health = 0;
            Destroy(this.gameObject);
            homeBase.GetComponent<HomeBase>().gold += gold;
        }
    }
    
}
