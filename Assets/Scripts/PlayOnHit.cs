using UnityEngine;
using System.Collections;

public class PlayOnHit : MonoBehaviour {
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void PlaySound(AudioClip SoundFX){

		AudioSource.PlayClipAtPoint (SoundFX, Camera.main.transform.position);
	}
}
