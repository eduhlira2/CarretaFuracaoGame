using UnityEngine;
using System.Collections;

public class Pontuacao : MonoBehaviour {

	public static int pontuacao;

	public UnityEngine.UI.Text txtPontos;
	public GameObject goodnt;
	public GameObject greatnt;
	public GameObject awesoment;
	public GameObject nicejumpnt;
	public GameObject tutorial;
	private int cont;

	// Use this for initialization
	void Start () {
		

		pontuacao = 0;
		PlayerPrefs.SetInt ("pontuacao", pontuacao);


		if (PlayerPrefs.GetInt ("Tutorial") <= 0) {
			cont = cont + 2;
			PlayerPrefs.SetInt ("Tutorial", cont); 
			tutorial.SetActive (true);
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (GameOver.continuePontuando == true) {
			pontuar ();

		}
		if (pontuacao > PlayerPrefs.GetInt ("recorder")) {
			PlayerPrefs.SetInt ("recorder", pontuacao);
		}
		if (pontuacao == 1000) {
			GameObject good;
			good = Instantiate (goodnt) as GameObject;
		}
		if (pontuacao == 2000) {
			GameObject good;
			good = Instantiate (greatnt) as GameObject;
		}
		if (pontuacao == 3000) {
			GameObject good;
			good = Instantiate (awesoment) as GameObject;
		}
		if (pontuacao == 4000) {
			GameObject good;
			good = Instantiate (nicejumpnt) as GameObject;
		}
	}
	void pontuar(){
		txtPontos.text = pontuacao.ToString ();
		pontuacao = pontuacao + 1;

		}
	}

