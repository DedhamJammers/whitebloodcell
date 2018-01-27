using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameVirus : MonoBehaviour {
	public Vector3 movement;

	// Use this for initialization
	void Start () {
		GameObject ground = GameObject.Find("Platform");
		Vector3 initposition = new Vector3 ((Random.value - 0.5f) * ground.transform.localScale.x, 1.5f, (Random.value - 0.5f) * ground.transform.localScale.z);
		GetComponent<Rigidbody> ().transform.position = initposition;
	}

	// Update is called once per frame
	void Update () {
		Vector3 accel = new Vector3 (Random.value-0.5f, 0, Random.value-0.5f);
		GetComponent<Rigidbody>().AddForce(accel, ForceMode.VelocityChange);
	}
}
