using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBack : MonoBehaviour {

	private Vector3 pos;
	public float mSpeed = 10.0f;
	public Transform orig;


	void FixedUpdate() {
		pos = new Vector3(transform.position.x, transform.position.y, transform.position.z + mSpeed * Time.deltaTime);
		transform.position = pos;
	}

	void OnTriggerEnter(Collider col) {
		if(col.gameObject.tag == "Death") {
			gameObject.transform.position = orig.transform.position;
		}

	}
}
