using UnityEngine;
using System.Collections;

public class MovieOffset : MonoBehaviour {

	private Material currentMaterial;
	public static float speedCenario;
	private float offset;

	// Use this for initialization
	void Start () {
		speedCenario = 0.20f;
		currentMaterial = GetComponent<Renderer> ().material;
		InvokeRepeating ("HighSpeed", 10, 2);
	}
	
	// Update is called once per frame
	void Update () {
	
		offset += speedCenario * Time.deltaTime;
		currentMaterial.SetTextureOffset ("_MainTex", new Vector2 (offset,0));

	}
	void HighSpeed(){

		speedCenario = speedCenario + 0.01f;

   }
}
