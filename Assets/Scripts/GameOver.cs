using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {

	public static int comensaldamorte;
	public GameObject gameover;
	public static bool continuePontuando;
	public GameObject restart;

	// Use this for initialization
	void Start () {
		continuePontuando = true;
		comensaldamorte = 0;
	}
	
	// Update is called once per frame
	void Update() {
		if (comensaldamorte == 5){
			Debug.Log ("GameOver");
			Invoke("gameOver", 2);
			comensaldamorte++;
			continuePontuando = false;
		}

	}
	void gameOver(){

		GameObject screen;

		screen = Instantiate (gameover) as GameObject;
		restart.SetActive (true);
	}
		

}
