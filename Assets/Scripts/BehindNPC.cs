using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BehindNPC : MonoBehaviour {

	public GameObject NPC;
	//string OrderInLayer = "Walls";

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.name == "Player") {
			//OrderInLayer = "TransparentWalls";
			NPC.GetComponent<SpriteRenderer> ().sortingOrder = 2;
		}

	}
	//Seina tagant väljudes
	void OnTriggerExit2D(Collider2D other) {
		if (other.gameObject.name == "Player") {
			//OrderInLayer = "Walls";
			NPC.GetComponent<SpriteRenderer> ().sortingOrder = 0;
		}

	}

}
