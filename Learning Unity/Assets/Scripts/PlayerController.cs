﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed = 10.0f;
	public float drag;
	public Text countText;
	public Text winText;

	private Rigidbody rb;
	private int count = 0;

	void Start () {
		rb = GetComponent<Rigidbody> ();
		rb.drag = drag;

		SetCountText ();
		winText.text = "";
	}

	void Update () {

	}

	void FixedUpdate () {
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rb.AddForce (movement * speed);
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.CompareTag ("Pick Up")) {
			other.gameObject.SetActive (false);
			count++;
			SetCountText ();
		}
	}

	void SetCountText () {
		countText.text = "Count: " + count;

		if (count >= 12)
			winText.text = "You Win!";
	}
}
