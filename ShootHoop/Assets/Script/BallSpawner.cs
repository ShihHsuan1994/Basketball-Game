using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour {

    public GameObject ballPrefab;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {

        float velocity = 5f;
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            GameObject instance = Instantiate(ballPrefab);
            Rigidbody rb = instance.GetComponent<Rigidbody>();
            instance.transform.position = transform.position;
            rb.velocity = Vector3.forward*velocity  ;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            GameObject instance = Instantiate(ballPrefab);
            Rigidbody rb = instance.GetComponent<Rigidbody>();
            rb.velocity = Vector3.back * velocity;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            GameObject instance = Instantiate(ballPrefab);           
            Rigidbody rb = instance.GetComponent<Rigidbody>();
            rb.velocity = Vector3.left * velocity;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            GameObject instance = Instantiate(ballPrefab);
            Rigidbody rb = instance.GetComponent<Rigidbody>();
            rb.velocity = Vector3.right * velocity;
        }
    }
}
