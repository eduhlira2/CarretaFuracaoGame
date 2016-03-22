using UnityEngine;
using System.Collections;

public class CharacterControl : MonoBehaviour {

	public Transform player;
	public float jumpTime = 0.4f;
	public float jumpDelay = 0.4f;
	public bool jumped = false;
	public float force;
	public bool isGrounded = true;
	public Transform ground;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		isGrounded = Physics2D.Linecast (this.transform.position, ground.position, 1 << LayerMask.NameToLayer ("Plataforma"));
		OnMouseDown ();
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
		/*(Input.GetMouseButtonDown(0)*/
		if (Input.GetMouseButtonDown(0) && isGrounded && !jumped) {

				GetComponent<Rigidbody2D>().AddForce(transform.up * force);
				jumpTime = jumpDelay;
				jumped = true;
			}

			jumpTime -= Time.deltaTime;


			if (jumpTime <= 0 && isGrounded && jumped) {
				jumped = false;
			}


	
 }
}
