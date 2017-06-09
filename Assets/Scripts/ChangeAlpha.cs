using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeAlpha : MonoBehaviour {
	float Transparency;
	public GameObject player;
	public GameObject Item;
	string OrderInLayer;
	public float distance;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		//arvutab vahemaa mehe ja seina alumise keskosa vahel
		distance = Vector3.Distance (player.transform.position, Item.transform.position);

		if (distance <= 0.25) {

			Transparency = .2f;
			OrderInLayer = "TransparentWalls";

		} else if(distance > 0.25) {

			Transparency = 1f;
			OrderInLayer="Walls";
		}
		//annab seinale tooni
		GetComponent<SpriteRenderer> ().color = new Color (1, 1, 1, Transparency);
		//muudab seina sorting layerit
		GetComponent<SpriteRenderer> ().sortingLayerName = OrderInLayer;

	}
}