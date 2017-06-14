using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MinigameTimer : MonoBehaviour {

	public string name;
	public float timeLeft = 30.0f; 
	public bool start = false;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp (KeyCode.Space)) {
			start = true;
		}
		while (start == true){
			timeLeft -= Time.deltaTime;
			if(timeLeft <= 0.0f){
				GameOver(name);
				start = false;
			}
		}

	}

	public void GameOver(string name){
		SceneManager.LoadScene(name);
	}


}
