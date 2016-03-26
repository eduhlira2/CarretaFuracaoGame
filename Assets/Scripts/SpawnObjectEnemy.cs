using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SpawnObjectEnemy : MonoBehaviour {

	public GameObject barreiraPrefab;
	public GameObject barreiraPrefab2;
	public GameObject barreiraPrefab3;

	public  static float rateSpawn;
	public float currentTime;
	private int posicao;
	private int inimigo;

	public float posdireito;




	// Use this for initialization
	void Start () {

		InvokeRepeating ("SpawnEnemy", 5, 3);

	}
	
	// Update is called once per frame
	void Update () {

		
	}

	void SpawnEnemy(){

							
	 inimigo= Random.Range (1, 5);

		GameObject obj;

		switch (inimigo){

		case 1:
			obj = Instantiate (barreiraPrefab) as GameObject;
			Debug.Log ("Funcionou");
			break;
		case 2:
			obj = Instantiate (barreiraPrefab2) as GameObject;
			break;
		case 3:
			obj = Instantiate (barreiraPrefab3) as GameObject;
			break;
		
	    }
    }
}
