using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Antibody : MonoBehaviour {

    public Slider wintime;
    public float starttime;
    public float currenttime;
    public float timeskip;
    public float timeBump;

	// Use this for initialization
	void Start () {
        currenttime = starttime;
	}
	
	// Update is called once per frame
	void Update () {
        wintime.value = currenttime;
        currenttime += timeskip * Time.deltaTime;
	}
    public float GetTime() { return currenttime; }
    public void BumpTime() {
        currenttime += timeBump;
    }
}
