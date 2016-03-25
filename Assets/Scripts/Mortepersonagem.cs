using UnityEngine;
using System.Collections;

public class Mortepersonagem : MonoBehaviour {

	public GameObject charMorto;
	Vector2 forca;
	public GameObject Player;
	public GameObject PlayerPopeyer;
	private Animator animator;
	public Transform camera;
	private bool tremer = true;

	// Use this for initialization
	void Start () {
		animator = camera.GetComponent<Animator> ();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter2D (Collider2D col){

		/*if(gameObject.name == ("Fofao")){
			Debug.Log("Bateu");
			Player.SetActive (false);
			InstanciarVikingsMortos ();
		}*/

		if(col.gameObject.tag == "car"){
		Debug.Log("Bateu");
		Player.SetActive (false);
		InstanciarVikingsMortos ();
		animator.SetTrigger("Treme");
		Invoke ("ParaTremer", 0.5f);
		tremer = true;
			GameOver.comensaldamorte = GameOver.comensaldamorte + 1;
	  }
	}

	void InstanciarVikingsMortos()
	{
		int randX, RandY;
		GameObject _viking1 = GameObject.Instantiate (charMorto, transform.position, transform.rotation) as GameObject;


		randX = 1000;
		RandY = 1000;
		forca = new Vector2 (randX, RandY);
		_viking1.GetComponent<Rigidbody2D>().isKinematic = false;
		_viking1.GetComponent<Rigidbody2D>().AddForce (forca);
		_viking1.GetComponent<Rigidbody2D>().angularVelocity = 1;


	} 
	void ParaTremer(){
		if (tremer == true) {
			animator.SetBool ("Treme", false);
			animator.SetBool ("Ntreme", true);

		}
	}

}
