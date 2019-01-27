using UnityEngine;
using System.Collections;

public class Weapon : MonoBehaviour {

    public float fireRate;
    public int damage;
    public float projectileSpeed;
    public Sprite projectileImage;
    public Vector3 velocity = new Vector3();
	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(velocity * Time.deltaTime);
	}
    void OnCollisionEnter(Collision coll)
    {
        if(coll.gameObject.CompareTag("Enemy"))
        {
            coll.gameObject.GetComponent<Enemy>().TakeDamage(damage);
            Destroy(this.gameObject);
        }
    }
}
