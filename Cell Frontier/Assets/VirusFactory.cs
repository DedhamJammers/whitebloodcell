using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirusFactory : MonoBehaviour {
	public int StartN;
	public int ViriiPerS;

	public GameObject virus;
	void Start() {
		for (int y = 0; y < StartN; y++) {
			GameObject v = Instantiate (virus);
		}
		StartCoroutine (Spawner());
	}

	IEnumerator Spawner() {
		while (true) {
			yield return new WaitForSeconds (1);
			for (int y = 0; y < ViriiPerS; y++)
				Instantiate (virus);
		}
	}
}
