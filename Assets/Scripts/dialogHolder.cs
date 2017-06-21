using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class dialogHolder : MonoBehaviour {

	public string dialogue;
	private DialogueManager dMan;
	public static QuestTrigger qTrig;
	private QuestManager theQM;
	public float distance;
	public string[] dialogueLines;
	public GameObject NPC;
	public GameObject Player;
	//private int skipper = 1;

	// Use this for initialization
	void Start () {
		dMan = FindObjectOfType<DialogueManager>();
		qTrig = FindObjectOfType<QuestTrigger> ();
		theQM = FindObjectOfType<QuestManager> ();
	}
	
	// Update is called once per frame
	void Update () {
		distance = Vector3.Distance(Player.transform.position, NPC.transform.position);

		if (ProgressSave.skipper == 4){
			theQM.quests [3].gameObject.SetActive (true);
			Debug.Log(RightAnswer.answer);
			if(RightAnswer.answer){
				theQM.ShowQuestText ("Tubli! Sa teenisid 25 EAP. Järgmine väljakutse ootab sind Romilli kabinetis!");
				ScoreScript.scoreValue += 25;
				theQM.quests [3].gameObject.SetActive (false);
				theQM.questCompleted [3] = true;
				ProgressSave.questProgress [3] = true;
				RightAnswer.answer = false;
				ProgressSave.skipper++;

			}else{
				theQM.ShowQuestText ("Sa ei vastanud õigesti ja kukkusid aine läbi. Järgmine väljakutse ootab sind Romilli kabinetis!");
				theQM.quests [3].gameObject.SetActive (false);
				theQM.questCompleted [3] = true;
				ProgressSave.questProgress [3] = true;
				ProgressSave.skipper++;
			}
		}

		if (ProgressSave.skipper == 8){
			theQM.quests [3].gameObject.SetActive (true);
			if(RightAnswer.answer){
				theQM.ShowQuestText ("Tubli! Sa teenisid 25 EAP. Sa oled valmis Peeter Normaku Teoreetiliseks informaatikaks!");
				ScoreScript.scoreValue += 25;
				theQM.quests [3].gameObject.SetActive (false);
				theQM.questCompleted [3] = true;
				ProgressSave.questProgress [3] = true;
				RightAnswer.answer = false;
				ProgressSave.skipper++;

			}else{
				theQM.ShowQuestText ("Sa ei vastanud õigesti ja kukkusid aine läbi. Loodetavasti oled valmis Peeter Normaku Teoreetiliseks informaatikaks!");
				theQM.quests [3].gameObject.SetActive (false);
				theQM.questCompleted [3] = true;
				ProgressSave.questProgress [3] = true;
				ProgressSave.skipper++;
			}

		}

		if (ProgressSave.skipper == 15){
			theQM.quests [3].gameObject.SetActive (true);
			if(RightAnswer.answer){
				theQM.ShowQuestText ("Tubli! Sa teenisid 25 EAP. Sa oled valmis lõpetama!");
				ScoreScript.scoreValue += 25;
				theQM.quests [3].gameObject.SetActive (false);
				theQM.questCompleted [3] = true;
				ProgressSave.questProgress [3] = true;
				RightAnswer.answer = false;
				ProgressSave.skipper++;

			}else{
				theQM.ShowQuestText ("Sa ei vastanud õigesti ja kukkusid aine läbi. See aasta ma küll vist ei lõpeta...");
				theQM.quests [3].gameObject.SetActive (false);
				theQM.questCompleted [3] = true;
				ProgressSave.questProgress [3] = true;
				ProgressSave.skipper++;
			}

		}

		if (ProgressSave.skipper == 11){
			theQM.quests [3].gameObject.SetActive (true);
			theQM.ShowQuestText ("Loodetavasti see pidu ei mõjunud mu tulemustele kuidagi halvasti... Mis ma tegema nüüd pidingi? Ahjaa... Teoreetilise informaatika eksam. God help me.");
			theQM.quests [3].gameObject.SetActive (false);
			theQM.questCompleted [3] = true;
			ProgressSave.questProgress [3] = true;
			ProgressSave.skipper++;
		}

		if (ProgressSave.skipper == 16){

			if (ScoreScript.scoreValue >= 60){
				SceneManager.LoadScene ("Win");
				ProgressSave.skipper = 1;
				ProgressSave.questProgress = null;
				ScoreScript.scoreValue = 0;
			}else{
				SceneManager.LoadScene ("Lose");
				ProgressSave.skipper = 1;
				ProgressSave.questProgress = null;
				ScoreScript.scoreValue = 0;
			}
		}

		//for teleporting

		if (distance <= 0.6) {

			if (!dMan.dialogActive && Player.name == "Player" && NPC.name == "Inga" &&
				theQM.questCompleted [2] == true && ProgressSave.skipper == 2) {
				ProgressSave.skipper = 3;
				SceneManager.LoadScene ("Minigame4");

			}
			if (!dMan.dialogActive && Player.name == "Player" && NPC.name == "Romil" &&
				theQM.questCompleted [3] == true && ProgressSave.skipper == 6) {
				ProgressSave.skipper = 7;
				SceneManager.LoadScene ("Minigame3");

			}

			if (!dMan.dialogActive && Player.name == "Player" && NPC.name == "Normak" &&
				theQM.questCompleted [3] == true && ProgressSave.skipper == 13) {
				ProgressSave.skipper = 14;
				SceneManager.LoadScene ("Minigame2");

			}

			if (!dMan.dialogActive && NPC.name == "Romil" && ProgressSave.skipper == 9 ||
				!dMan.dialogActive && NPC.name == "Inga" && ProgressSave.skipper == 9 ||
				!dMan.dialogActive && NPC.name == "heinrich" && ProgressSave.skipper == 9 ||
				!dMan.dialogActive && NPC.name == "Normak" && ProgressSave.skipper == 9){

				ProgressSave.skipper = 10;
				SceneManager.LoadScene ("Minigame1");

			}




			//for talking

			if (Input.GetKeyUp (KeyCode.E)) {
				//dMan.ShowBox (dialogue);

				if (!dMan.dialogActive) {
					//Debug.Log ("siin1");
					if (Player.name == "Player" && NPC.name == "Inga" && theQM.questCompleted [2] == false &&
					    theQM.questCompleted [0] == true) {


						dMan.dialogLines = dialogueLines;
						dMan.currentLine = 0;
						dMan.ShowDialogue ();

						//Debug.Log ("siin2");
						//theQM.quests [2].EndQuest ();
						//theQM.ShowQuestText (endText);
						theQM.questCompleted [2] = true;
						ProgressSave.questProgress [2] = true;
						//ScoreScript.scoreValue += 4;
						theQM.quests [2].gameObject.SetActive (false);
						ProgressSave.skipper = 2;





					} else if (Player.name == "Player" && NPC.name == "Normak" && theQM.questCompleted [0] == false) {
						//theQM.quests [2].EndQuest ();
						//theQM.ShowQuestText (endText);
						qTrig.gameObject.SetActive (false);
						theQM.questCompleted [0] = true;
						ProgressSave.questProgress [0] = true;
						theQM.quests [0].gameObject.SetActive (false);
						theQM.quests [2].gameObject.SetActive (true);
						//ScoreScript.scoreValue += 6;



						dMan.dialogLines = dialogueLines;
						dMan.currentLine = 0;
						dMan.ShowDialogue ();
					
					} else if (Player.name == "Player" && NPC.name == "Normak" && ProgressSave.skipper == 12){

						//custom dialog
						//dMan.dialogLines = new string[3];
						dMan.dialogLines = new string[]{"Näen, et oled kõik vajalikud ained läbinud","Sind ootab nüüd Teoreetilise informaatika eksam","Loodan, et oled valmistunud"};
						dMan.currentLine = 0;
						dMan.ShowDialogue ();
						ProgressSave.skipper = 13;

					}else if (Player.name == "Player" && NPC.name == "Romil" && ProgressSave.skipper == 5){

						//theQM.quests [4].gameObject.SetActive (true);

						dMan.dialogLines = dialogueLines;
						dMan.currentLine = 0;
						dMan.ShowDialogue ();

						ProgressSave.skipper = 6;
						
					} else if (Player.name == "Player" && NPC.name == "heinrich"){
						dMan.dialogLines = dialogueLines;
						dMan.currentLine = 0;
						dMan.ShowDialogue ();

					} else if (theQM.questCompleted [1] == false && theQM.questCompleted [2] == false) {
						theQM.ShowQuestText ("Mul ei ole sulle midagi öelda.");
					} else {

						theQM.ShowQuestText ("Mul ei ole sulle midagi öelda.");
					}
						

				}


			}
		

		} else {
			NPC.GetComponentInChildren<Renderer> (false);
			//NPC.GetComponent<SpriteRenderer> ().gameObject.SetActive (true);
		}
	}
}
