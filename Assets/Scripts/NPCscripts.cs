using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCscripts : MonoBehaviour {

	public GameObject NPC;
	//string OrderInLayer = "Walls";
	/*
	public float Distance;
	public float Range = 15.0f;
	public Transform target;
	public bool talk = false;
	*/
	// Use this for initialization
	void Start () {

		/*
		Distance = Vector3.Distance (transform.position, target.position);
		if (Distance < Range) {
			talk = true;
		}

		*/
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
	/*
	void OnGUI(){
		Vector3 getPixelPos = Camera.main.WorldToScreenPoint (target.position);
		getPixelPos.y = Screen.height - getPixelPos.y;
		GUI.Label (new Rect (getPixelPos.x, getPixelPos.y, 200f, 100f), "ITS ME, MARIO !");
	}
	*/
}
