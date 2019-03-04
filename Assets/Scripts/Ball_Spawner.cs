using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Spawner : MonoBehaviour {

    public GameObject ball_prefab;
    public float speed = 10.0f;

	// Use this for initialization
	void Start () {	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown(("Fire1")))
        {
            GameObject instance = Instantiate(ball_prefab);
            instance.transform.position = transform.position; // get location
            Rigidbody rb = instance.GetComponent<Rigidbody>();

            Camera camera = GetComponentInChildren<Camera>(); //direction

            rb.velocity = camera.transform.rotation * Vector3.forward * speed;
        }		
	}
}
