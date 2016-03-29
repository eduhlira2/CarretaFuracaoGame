using UnityEngine;
using System.Collections;

public class SplashScene : MonoBehaviour {

	public string LevelToLoad;

	// Use this for initialization
	void Start () {

		Invoke ("Splash", 4);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void Splash(){

		Application.LoadLevel(LevelToLoad);

	}
}
