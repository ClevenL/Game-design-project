import UnityEngine.SceneManagement;

#pragma strict

var scene : String;

function OnTriggerEnter2D(Col: Collider2D)
{
	if(Col.CompareTag("Player"))
	{
		SceneManager.LoadScene(scene);
	}
}
