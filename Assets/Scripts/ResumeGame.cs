using UnityEngine;
using System.Collections;

public class ResumeGame : MonoBehaviour {
	public GameObject PauseMenu;
	public string GameControllerTag;
	public static bool pausepontos; 

	void Start(){
		pausepontos = false; 
	}

	void OnMouseDown()
	{
		if (gameObject.name.Equals ("bnt-pause")) {
			GameObject.FindGameObjectWithTag("pause").GetComponent<SpriteRenderer>().enabled = false;
			PauseMenu.SetActive(true);
			GameObject.FindGameObjectWithTag(GameControllerTag).GetComponent<PauseGame>().SetPause(true);
			pausepontos = true;
		}

		if (gameObject.name.Equals ("Menu HUD_0")) {
			GameObject.FindGameObjectWithTag("pause").GetComponent<SpriteRenderer>().enabled = true;

			PauseMenu.SetActive(false);
			GameObject.FindGameObjectWithTag(GameControllerTag).GetComponent<PauseGame>().SetPause(false);
			pausepontos = false;
		}


	}

	void Stop()
	{
		Time.timeScale = 0;
	}

}
