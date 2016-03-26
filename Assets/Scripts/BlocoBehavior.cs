using UnityEngine;
using System.Collections;

public class BlocoBehavior : MonoBehaviour {


	public float x;





	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

		x = transform.position.x;
		x += -MovieOffset.speedCenario - 0.02f;
		transform.position = new Vector3 (x, transform.position.y, transform.position.z);

		if (x <= -16.2f) {
			Destroy (transform.gameObject);
		}
		/*if (MovieOffset.speedCenario >= 0.25f) {
			speed = -13;
		}
		if (MovieOffset.speedCenario >= 0.30f) {
			speed = -14;
		}
		if (MovieOffset.speedCenario >= 0.35f) {
			speed = -15;
		}
		if (MovieOffset.speedCenario >= 0.40f) {
			speed = -16;
		}
		if (MovieOffset.speedCenario >= 0.45f) {
			speed = -20;
		}
		if (MovieOffset.speedCenario >= 0.50f) {
			speed = -23;
		}
		if (MovieOffset.speedCenario >= 0.55f) {
			speed = -27;
		}
		if (MovieOffset.speedCenario >= 0.70f) {
			speed = -33;
		}*/


	}

}
