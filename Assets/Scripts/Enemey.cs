using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class Enemey : MonoBehaviour {

	//Members
	public float health = 1.0f;
	public float pointsGiven = 1.0f;
	public float moveSpeed = 2.0f;
	private float passedTime = 0.0f;
	private GameObject player;
	public NavMeshAgent agent;

	void Start() {
		player = GameObject.FindWithTag("Player");
		
	}

	// Update is called once per frame
	void Update () {
		agent.SetDestination(player.transform.position);
		/*
		transform.LookAt(player.transform);
		passedTime += 1 * Time.deltaTime;
		if (passedTime >= 1) {
			transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
		}
		*/
		if (health <= 0) {
			Die();
		}


	}
	void Die()
	{
		//print("Enemy dies" + this.gameObject.name);
		player.GetComponent<Player>().points += 1;
		Destroy(this.gameObject);
		
	}
	void OnCollisionEnter(Collision other) {
		if (other.gameObject.tag == "bullet") {
			Destroy(this.gameObject);
		}
	}
}
