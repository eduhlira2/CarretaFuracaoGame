﻿using UnityEngine;
using System.Collections;
using UnityEngine.Advertisements;

public class AdManager : MonoBehaviour {

	[SerializeField] string gameID = "1052313";

	void Awake(){
		Advertisement.Initialize (gameID, false );
	}

	public void ShowAd(){
		if (Advertisement.IsReady () && GameOver.adOn == true) {
			Debug.Log ("Olha o AD aew");
		Advertisement.Show ();
		
	}
  }
}


