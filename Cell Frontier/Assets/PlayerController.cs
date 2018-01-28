using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    public Vector3 movement;
    public float Speed;
    public Vector3 LookPos;
    public GameObject LookPlane;
    public GameObject WaveProjectile;
    public bool CanFire;
    public float FireRate;
    // Use this for initialization
    void Start () {
        Speed = 400f;
        FireRate = 8;
        CanFire = true;
	}
	
	// Update is called once per frame
	void Update () {
        movement = new Vector3(Input.GetAxis("Horizontal")*Time.deltaTime*Speed,0,Input.GetAxis("Vertical")*Time.deltaTime*Speed); //sets a Vector3 to built-in WASD axis', applies time delta to keep the speed constant and multiplies it by a speed variable
        transform.position += movement/100;
        Camera.main.transform.position = new Vector3(transform.position.x, transform.position.y + 19, transform.position.z - 4);
        LookPlane.transform.position = transform.position;
        GetComponent<Rigidbody>().AddForce(movement); //applys the force to the player's rigidbody
        transform.LookAt(LookPos);
        if (Input.GetKey("space")&&CanFire==true)
        {
            Instantiate(WaveProjectile,transform.position,transform.rotation);
            StartCoroutine(Reload());
            
        }
    }
    IEnumerator Reload()
    {
        CanFire = false;
        yield return new WaitForSeconds(1/FireRate);
        CanFire = true;
    }
}
