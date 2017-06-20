using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MinigameTimer : MonoBehaviour {

	public GameObject syringe;
	GameObject syringeClone;


	public string name;
	public float timeLeft = 30f;
	public float spawnTime = 0.2f;
	public bool start = false;
	private DialogueManager dMan;

	public string[] dialogueLines;
	public string[] dialogueLines2;
	private int skipper=1;

	// Use this for initialization
	void Start () {
		dMan = FindObjectOfType<DialogueManager>();

	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.Space) && skipper == 2 && !dMan.dialogActive) {
			start = true;
		}
		if (Input.GetKeyDown (KeyCode.Space) && skipper == 3 && !dMan.dialogActive) {
			GameOver (name);
		}
		
		if (start == true) {
			timeLeft -= Time.deltaTime;
			spawnTime -= Time.deltaTime;

			if (spawnTime <= 0.0f) {
				transform.position = new Vector3(Random.Range(-2.6f, 2.6f), 4f);
				transform.rotation = Quaternion.Euler(0, 0, -90);
				syringeClone = Instantiate(syringe, transform.position, transform.rotation) as GameObject;
				spawnTime = 0.2f;
			}




			if (timeLeft <= 0.0f && skipper == 2) {
				start = false;
				//dMan.dBox.SetActive(false);
				dMan.dialogLines = dialogueLines;
				dMan.currentLine = 0;
				dMan.ShowDialogue ();
				skipper = skipper + 1;
				//yield return WaitForSeconds (2);



			}
		}
	}

	void OnTriggerEnter2D(Collider2D other){


		if (other.gameObject.name == "Player" && timeLeft ==30.0f && skipper == 1) {
			dMan.dialogLines = dialogueLines2;
			dMan.currentLine = 0;
			dMan.ShowDialogue ();

			//yield return new WaitForSeconds (2);
			//
			skipper = skipper + 1;

			//SortingLayer = "TransparentWalls";
		}

	}





	public void GameOver(string name){
		ProgressSave.skipper = 11;
		Debug.Log(ProgressSave.skipper);
		SceneManager.LoadScene(name);
	}


}
