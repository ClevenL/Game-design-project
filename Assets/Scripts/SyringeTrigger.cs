using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SyringeTrigger : MonoBehaviour {

	void OnTriggerEnter(Collider collider){
	    if(collider.gameObject.tag == "syringe")
	    {
			ScoreScript.scoreValue --;
	        Debug.Log("got hit!");
	        Destroy(collider.gameObject);

	    }
	}
}
