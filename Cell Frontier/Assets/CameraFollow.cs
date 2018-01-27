using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {
    public Vector3 FollowPos;
    public GameObject Player;
	// Use this for initialization
	void Start () {
        Player = GameObject.FindGameObjectWithTag("Player");
    }
	
	// Update is called once per frame
	void Update () {
        //FollowPos = new Vector3(Player.transform.position.x,Player.transform.position.y+22,Player.transform.position.z-4); //sets a vector3 to the prefered offset off 
        //transform.position = FollowPos;
	}
}
