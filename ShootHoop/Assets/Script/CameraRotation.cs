using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour {

	// Use this for initialization
	void Start () {
 
    }
	
	// Update is called once per frame
	void Update () {
        float rotationspeed = 5.0f;
        float mouseX = Input.GetAxis("Mouse X")*rotationspeed;
        float mouseY = Input.GetAxis("Mouse Y")*rotationspeed;
        transform.localRotation = Quaternion.Euler(0, -mouseX, 0) * transform.localRotation;
        Camera camera = transform.GetComponentInChildren<Camera>();
        camera.transform.localRotation = Quaternion.Euler(-mouseY, 0, 0)*camera.transform.localRotation;
	}
}
