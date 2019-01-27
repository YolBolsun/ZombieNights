using UnityEngine;
using System.Collections;

public class TiltControl : MonoBehaviour {
    public Transform camera;
    public Transform cameraPosition1;
    public Transform cameraPosition2;
    public Transform cameraPosition3;
    public Transform cameraPosition4;
    public Transform cameraPosition5;
    public float cameraShiftSpeed;
    public float tiltAmount;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        Vector3 desiredPosition = cameraPosition1.position;
        float desiredZ = desiredPosition.z;
	    if(Input.acceleration.x > tiltAmount)
        {
            //Debug.Log("x: "+Input.acceleration.x);
            //TODO move camera to the right
            //camera.Translate((cameraPosition2.position-camera.position)*cameraShiftSpeed*Time.deltaTime);
            desiredPosition += cameraPosition2.position;
        }
        if (Input.acceleration.y < -(tiltAmount))
        {
            //Debug.Log("y: " +Input.acceleration.y);
            //TODO move camera down
            //camera.Translate((cameraPosition3.position - camera.position) * cameraShiftSpeed * Time.deltaTime);
            desiredPosition += cameraPosition3.position;
        }
        if (Input.acceleration.x < -(tiltAmount))
        {
            //Debug.Log("x: "+Input.acceleration.x);
            //TODO move camera to the left
            //camera.Translate((cameraPosition4.position - camera.position) * cameraShiftSpeed * Time.deltaTime);
            desiredPosition += cameraPosition4.position;
        }
        if (Input.acceleration.y > tiltAmount)
        {
            //Debug.Log("y: "+Input.acceleration.y);
            //TODO move camera up
            //camera.Translate((cameraPosition5.position - camera.position) * cameraShiftSpeed * Time.deltaTime);
            desiredPosition += cameraPosition5.position;
        }
        /*if (!(Input.acceleration.y > tiltAmount || Input.acceleration.x < -(tiltAmount) || Input.acceleration.y < -(tiltAmount) || Input.acceleration.x > tiltAmount))
        {
            camera.Translate((cameraPosition1.position - camera.position) * cameraShiftSpeed * Time.deltaTime);
        }*/
        desiredPosition.z = desiredZ;
        camera.Translate((desiredPosition - camera.position) * cameraShiftSpeed * Time.deltaTime);

	}
}
