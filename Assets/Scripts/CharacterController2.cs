using UnityEngine;
using System.Collections;

public class CharacterController2 : MonoBehaviour {

	public GameObject player;
	public GameObject player2;

	public float jumpTime = 0.4f;
	public float jumpDelay = 0.4f;
	public bool jumped = false;
	public float force;
	public bool isGrounded = true;
	public Transform ground;
	public bool delay;
	public bool delaymain;
	public AudioSource audioMickey;
	public AudioSource audioCapitao;

	public AudioClip audiojump;
	public AudioClip audioCrash;


	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		isGrounded = Physics2D.Linecast (this.transform.position, ground.position, 1 << LayerMask.NameToLayer ("Plataforma2"));

	}

	/*void JumpCharacter()
	{

		isGrounded = Physics2D.Linecast (this.transform.position, ground.position, 1 << LayerMask.NameToLayer ("Plataforma"));
		
		if (gameObject.name == "Cenario") {
			GetComponent<Rigidbody2D> ().AddForce (transform.up * force);
			jumpTime = jumpDelay;
			jumped = true;

			jumpTime -= Time.deltaTime;
		}

		if (jumpTime <= 0 && isGrounded && jumped) {
			jumped = false;
		}

	}*/

	void OnMouseDown()
	{
		//Time.timeScale = 1;

		if (gameObject.name == ("Control_Left") && isGrounded && !jumped) {

			player.GetComponent<Rigidbody2D>().AddForce(transform.up * force);
			jumpTime = jumpDelay;
			jumped = true;


		}

		if (gameObject.name == ("Control_Right") && isGrounded && !jumped) {

			player.GetComponent<Rigidbody2D>().AddForce(transform.up * force);
			jumpTime = jumpDelay;
			jumped = true;
			audioMickey.GetComponent<AudioSource> ().PlayOneShot(audiojump);


		}
		/*(Input.GetMouseButtonDown(0)*/
		/*if (Input.GetMouseButtonDown(0) && isGrounded && !jumped) {


	}*/

	jumpTime -= 1;


	if (jumpTime <= 0 && isGrounded && jumped) {
		jumped = false;
	}
	if (delay == false){

		Invoke ("palhaco", 0.1f);

	}
}

void palhaco(){
	delay = true;
	player2.GetComponent<Rigidbody2D>().AddForce(transform.up * force);
	audioCapitao.GetComponent<AudioSource> ().PlayOneShot(audiojump);
	Invoke ("Delay", 0.9f);

}


void Delay(){
	delay = false;
}

}
