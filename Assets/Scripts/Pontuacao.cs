using UnityEngine;
using System.Collections;

public class Pontuacao : MonoBehaviour {

	public static int pontuacao;

	public UnityEngine.UI.Text txtPontos;

	// Use this for initialization
	void Start () {
	    
		pontuacao = 0;
		PlayerPrefs.SetInt ("pontuacao", pontuacao);

	}
	
	// Update is called once per frame
	void Update () {
		if (GameOver.continuePontuando == true) {
			pontuar ();

		}
		if (pontuacao > PlayerPrefs.GetInt ("recorder")) {
			PlayerPrefs.SetInt ("recorder", pontuacao);
		}
	}
	void pontuar(){
		txtPontos.text = pontuacao.ToString ();
		pontuacao = pontuacao + 1;

		}
	}

