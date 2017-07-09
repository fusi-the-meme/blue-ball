using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Kai G was here

public class CameraController : MonoBehaviour {

    public GameObject player;

    private Vector3 offset;

	// working out current obj
	void Start () {
        offset = transform.position - player.transform.position;
	}
	
	// updating camera
	void LateUpdate () {
        transform.position = player.transform.position + offset;
	}
}
