﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
	public float moveSpeed = 7.0f;
	private float maxDistance = 0.0f;
	private float damege = 1.0f;

	private GameObject triggerEnemy;

	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
		maxDistance += 1 * Time.deltaTime;
		if (maxDistance >= 5) {
			Destroy(this.gameObject);
		}
	}

	void OnTriggerEnter(Collider other) {
		if (other.tag == "Enemey") {
			triggerEnemy = other.gameObject;
			triggerEnemy.GetComponent<Enemey>().health -= damege;
			Destroy(this.gameObject);
		}
	}
}
