using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveScript : MonoBehaviour {
    public float elapsed;
	// Use this for initialization
	void Start () {
        transform.eulerAngles += new Vector3(0,90,0);
        GetComponent<Rigidbody>().AddForce(-transform.right*20,ForceMode.Impulse);
        Destroy(gameObject,0.8f);
	}
	
	// Update is called once per frame
	void Update () {
        transform.localScale += new Vector3(Time.deltaTime*3.5f,Time.deltaTime*3.5f,Time.deltaTime*3.5f);


	}
    
}
