using UnityEngine;
using System.Collections;

public class WeaponManager : MonoBehaviour {

    public GameObject weapon1;
    public Transform homeBase;
    float lastFireTime;
    float timeBetweenShots;
    //This is a bitmask representing the 8th layer (Background layer)
    int backgroundLayer = 1 << 8;

	// Use this for initialization
	void Start () {
        timeBetweenShots = 1 / weapon1.GetComponent<Weapon>().fireRate;
        lastFireTime = timeBetweenShots;
	}
	
	// Update is called once per frame
	void Update () {
        lastFireTime += Time.deltaTime;
	    if(Input.GetKey(KeyCode.Mouse0) && lastFireTime > timeBetweenShots)
        {
            GameObject projectile = (GameObject)GameObject.Instantiate(weapon1, homeBase.position, Quaternion.identity);
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            Physics.Raycast(ray, out hit, 100,backgroundLayer);
            projectile.GetComponent<Weapon>().velocity = (hit.point-homeBase.position).normalized*weapon1.GetComponent<Weapon>().projectileSpeed;
            Destroy(projectile, 5);
            lastFireTime = 0;
        }
	}
}
