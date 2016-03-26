using UnityEngine;
using System.Collections;

public class GameOverScreen : MonoBehaviour {

	public UnityEngine.UI.Text recorde;

	// Use this for initialization
	void Start () {
		recorde.text = PlayerPrefs.GetInt("recorder").ToString ();

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
