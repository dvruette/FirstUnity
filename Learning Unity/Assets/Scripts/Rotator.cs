using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {

	private Vector3 position;
	private float speed;

	void Start () {
		position = transform.position;
		speed = Random.value + 1f;
	}

	void Update () {
		transform.Rotate (new Vector3 (15, 30, 45) * Time.deltaTime);
		transform.position = position + (new Vector3 (0, 0.2f, 0) * Mathf.Sin (speed * Time.time));
	}
}
