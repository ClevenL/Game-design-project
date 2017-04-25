using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {
	public void LoadLevel(string name){
		Debug.Log (name);
		Application.LoadLevel(name);
	}
	public void QuitRequest(){
		Debug.Log ("quit");
		Application.Quit();
	}
}
// TEST