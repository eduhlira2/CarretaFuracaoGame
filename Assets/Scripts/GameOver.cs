using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {

	public static int comensaldamorte;
	public GameObject gameover;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update() {
		if (comensaldamorte == 5){
			Debug.Log ("GameOver");
			Invoke("gameOver", 2);
			comensaldamorte++;
		}

	}
	void gameOver(){

		GameObject screen;

		screen = Instantiate (gameover) as GameObject;
	}
		

}
