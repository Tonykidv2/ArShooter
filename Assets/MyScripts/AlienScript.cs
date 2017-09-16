using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienScript : MonoBehaviour {

    public Transform mObject;
    public float Speed = 3;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.RotateAround(mObject.position, new Vector3(0, 1, 0), Time.deltaTime * Speed);
	}

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
