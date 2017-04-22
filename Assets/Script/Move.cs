using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

	public float speed;

	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody> ().velocity = transform.forward * speed;
	}
}
