using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour {

	void OnTriggerEnter2D ( Collider2D Col ){ 
		if(Col.tag == ("Player")) {
			SceneManager.LoadScene("Minigame2");
		} 
	}
}
