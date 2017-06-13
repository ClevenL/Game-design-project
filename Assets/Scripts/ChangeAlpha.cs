using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeAlpha : MonoBehaviour {
	float Transparency = 1f;
	public GameObject[] Item;
	string OrderInLayer = "Walls";
	int i;

	// Use this for initialization
	void Start () {
		
	}


	//Seina taha minnes
	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.name == "Player") {
			Transparency = .6f;
			OrderInLayer = "TransparentWalls";
		}
		for (i = 0; i < Item.Length; i++) {
			
			Item [i].GetComponent<SpriteRenderer> ().color = new Color (1, 1, 1, Transparency);
			Item [i].GetComponent<SpriteRenderer> ().sortingLayerName = OrderInLayer;

		}
	}
	//Seina tagant väljudes
	void OnTriggerExit2D(Collider2D other) {
		if (other.gameObject.name == "Player") {
			Transparency = 1f;
			OrderInLayer = "Walls";
		}
		for (i = 0; i < Item.Length; i++) {

			Item [i].GetComponent<SpriteRenderer> ().color = new Color (1, 1, 1, Transparency);
			Item [i].GetComponent<SpriteRenderer> ().sortingLayerName = OrderInLayer;

		}
	}


	// Update is called once per frame
	void Update () {

	}




	

}