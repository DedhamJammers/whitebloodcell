﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameVirus : MonoBehaviour {
	public Vector3 movement;
	public AudioSource source;
	public AudioClip die;
	public damage healthbar;
    public Antibody wintime;

	// Use this for initialization
	void Start () {
		source = GameObject.Find ("Sound Manager").GetComponent<AudioSource> ();
		healthbar = GameObject.Find ("healthbar").GetComponent<damage> ();
        wintime = GameObject.FindGameObjectWithTag ("Slider").GetComponent<Antibody> ();
	}

	void Awake() {
		GameObject ground = GameObject.Find("Platform");
		Vector3 initposition = new Vector3 ((Random.value - 0.5f) * ground.transform.localScale.x, 1.5f, (Random.value - 0.5f) * ground.transform.localScale.z);
		GetComponent<Rigidbody> ().transform.position = initposition;
	}

	// Update is called once per frame
	void Update () {
		Vector3 accel = new Vector3 (Random.value-0.5f, 0, Random.value-0.5f);
		GetComponent<Rigidbody>().AddForce(accel, ForceMode.VelocityChange);
		if (GetComponent<Rigidbody> ().transform.position.y < 0)
			Die ();
	}

	//Remove virus if it collides with the white blood cell
	void OnCollisionEnter(Collision col) {
		if (col.gameObject.name == "White Blood Cell") {
            Die();
		}
	}
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Projectile")
        {
            Die();
        }
    }
    public void Die()
    {
		healthbar.BumpHealth ();

        source.PlayOneShot(die, 1f);
        Object.Destroy(this.gameObject);
        wintime.BumpTime ();
    }
}
