using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {

	public static int comensaldamorte;
	public GameObject gameover;
	public static bool continuePontuando;
	public GameObject restart;
	public GameObject fundoGO;
	public GameObject menu;
	public static bool adOn;
	public static int contAnuncio;

	// Use this for initialization
	void Start () {
		continuePontuando = true;
		comensaldamorte = 0;
		adOn = false;
	}
	
	// Update is called once per frame
	void Update() {
		if (comensaldamorte == 5){
			Debug.Log ("GameOver");
			Invoke("gameOver", 2);
			comensaldamorte++;
			continuePontuando = false;

		}
		if (PlayerPrefs.GetInt ("Anunciar") == 2) {
			PlayerPrefs.SetInt ("Anunciar", 1);
			contAnuncio = 0;
			Debug.Log ("ContAnuncio Zerou!!!!");
			adOn = true;
		}

	}
	void gameOver(){
		contAnuncio = contAnuncio + 1;
		GameObject screen;
		PlayerPrefs.SetInt ("Anunciar", contAnuncio );
		screen = Instantiate (gameover) as GameObject;
		restart.SetActive (true);
		menu.SetActive (true);
		fundoGO.SetActive (true);
	}
		

}
