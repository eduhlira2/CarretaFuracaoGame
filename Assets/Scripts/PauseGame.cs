using UnityEngine;
using System.Collections;

public class PauseGame : MonoBehaviour {
	private bool SetPauseState;
	public GameObject PauseGameObject;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (SetPauseState ||PauseGameObject.activeInHierarchy ) {
			Time.timeScale = 0;
		} else {
			Time.timeScale = 1;
		}
	}
	public void SetPause(bool State){
		this.SetPauseState = State;
	}
}
