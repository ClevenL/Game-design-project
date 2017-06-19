using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SyringeTrigger : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D collider){
	    if(collider.gameObject.tag == "syringe")
	    {
			ScoreScript.scoreValue --;
	        Debug.Log("got hit!");
	        Destroy(collider.gameObject);

			if(ScoreScript.scoreValue < 0){
				ScoreScript.scoreValue = 0;
	        }

	    }
	}
}
