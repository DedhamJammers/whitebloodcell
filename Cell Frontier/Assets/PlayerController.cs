using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    public Vector3 movement;
    public float Speed;
	// Use this for initialization
	void Start () {
        Speed = 400f;
	}
	
	// Update is called once per frame
	void Update () {
        movement = new Vector3(Input.GetAxis("Horizontal")*Time.deltaTime*Speed,0,Input.GetAxis("Vertical")*Time.deltaTime*Speed); //sets a Vector3 to built-in WASD axis', applies time delta to keep the speed constant and multiplies it by a speed variable
        transform.position += movement/100;
        Camera.main.transform.position = new Vector3(transform.position.x, transform.position.y + 19, transform.position.z - 4);
        GetComponent<Rigidbody>().AddForce(movement); //applys the force to the player's rigidbody
	}
}
