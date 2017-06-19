import UnityEngine.SceneManagement;

#pragma strict

var scene : String;

function OnTriggerEnter2D(Col: Collider2D)
{
	if(Col.CompareTag("Player"))
	{
		yield WaitForSeconds(5);
		SceneManager.LoadScene(scene);
	}
}
