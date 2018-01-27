using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCursor : MonoBehaviour {
    public GameObject Player;
	// Use this for initialization
	void Start () {
        Player = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(ray.origin, ray.direction * 20, Color.yellow);
        RaycastHit hit;
        if (Physics.Raycast(ray.origin, ray.direction, out hit, 200))
        {
            if (hit.transform.name == "LookPlane")
            {
                Debug.Log("1");
                Player.GetComponent<PlayerController>().LookPos = new Vector3(hit.point.x, hit.point.y + 1, hit.point.z);
            }
        }
    }
}
