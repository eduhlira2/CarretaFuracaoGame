using UnityEngine;
using System.Collections;

public class CharacterControl : MonoBehaviour {

	public GameObject player;
	public GameObject player2;
	public GameObject player3;
	public float jumpTime = 0.4f;
	public float jumpDelay = 0.4f;
	public bool jumped = false;
	public float force;
	public bool isGrounded = true;
	public Transform ground;
	public bool delay;
	public bool delaymain;



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		isGrounded = Physics2D.Linecast (this.transform.position, ground.position, 1 << LayerMask.NameToLayer ("Plataforma"));

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
			delaymain = true;

		}

		if (gameObject.name == ("Control_Right") && isGrounded && !jumped) {

			player.GetComponent<Rigidbody2D>().AddForce(transform.up * force);
			jumpTime = jumpDelay;
			jumped = true;
			delaymain = true;

		}
		/*(Input.GetMouseButtonDown(0)*/
		/*if (Input.GetMouseButtonDown(0) && isGrounded && !jumped) {

				
		}*/

		jumpTime -= 1;


			if (jumpTime <= 0 && isGrounded && jumped) {
				jumped = false;
			}
	if (delay == false){

		Invoke ("palhaco", 0.2f);
		Invoke ("popeyer", 0.1f);

	   }
    }

void palhaco(){
	delay = true;
	player2.GetComponent<Rigidbody2D>().AddForce(transform.up * force);

	Invoke ("Delay", 0.9f);

	}
void popeyer(){
	delay = true;
	player3.GetComponent<Rigidbody2D>().AddForce(transform.up * force);

	Invoke ("Delay", 0.9f);

}

void Delay(){
		delay = false;
	}



}
