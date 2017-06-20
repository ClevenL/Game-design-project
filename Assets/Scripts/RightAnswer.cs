using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RightAnswer : MonoBehaviour {

	private bool inVastus1 = false;
	private bool inVastus2 = false;
	private bool inVastus3 = false;

	public static bool answer = false;

	public bool Vastus1Answer = false;
	public bool Vastus2Answer = false;
	public bool Vastus3Answer = false;

	void OnTriggerEnter2D(Collider2D collider){
	    if(collider.gameObject.name == "Vastus1"){
			inVastus1 = true;
	    }
		if(collider.gameObject.name == "Vastus2"){
			inVastus2 = true;
	    }
		if(collider.gameObject.name == "Vastus3"){
			inVastus3 = true;
	    }
	}
	void OnTriggerExit2D(Collider2D collider){
	    if(collider.gameObject.name == "Vastus1"){
			inVastus1 = false;
	    }
		if(collider.gameObject.name == "Vastus2"){
			inVastus2 = false;
	    }
		if(collider.gameObject.name == "Vastus3"){
			inVastus3 = false;
	    }
	}
	void Update () {
		if (inVastus1){
			if (Input.GetKeyDown (KeyCode.Space)){
				Debug.Log("vastus1");
				if(Vastus1Answer){
					answer = true;
				}
				LoadArena();
		    }
		}
		if (inVastus2){
			if (Input.GetKeyDown (KeyCode.Space)){
				Debug.Log("vastus2");
				if(Vastus2Answer){
					answer = true;
				}
				LoadArena();
		    }
		}
		if (inVastus3){
			if (Input.GetKeyDown (KeyCode.Space)){
				Debug.Log("vastus3");
				if(Vastus3Answer){
					answer = true;
				}

				LoadArena();
		    }
		}

	}
	void LoadArena(){
		ProgressSave.skipper++;
		Debug.Log(ProgressSave.skipper);
		SceneManager.LoadScene("Arena 1");
	}
}



