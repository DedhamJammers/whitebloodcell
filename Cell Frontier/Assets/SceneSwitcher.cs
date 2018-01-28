using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneSwitcher : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		damage d = GameObject.Find ("healthbar").GetComponent<damage>();
		if (d.GetHealth () <= 0)
			SceneManager.LoadScene ("Menu");
		
	}
    public void SwitchToGameScene()
    {
        SceneManager.LoadScene("GameScene");
            }

	public void QuitGame() {
		Application.Quit();
	}
}
