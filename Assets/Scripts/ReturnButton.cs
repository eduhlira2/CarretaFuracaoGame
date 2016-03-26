using UnityEngine;
using System.Collections;

public class ReturnButton : MonoBehaviour {
	public GameObject ExitSplash;
	public float WaitSeconds;
	private bool CanTouch=true;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (CanTouch) {
			if (Input.GetKey (KeyCode.Escape)) {
				if (!ExitSplash.activeInHierarchy) {
					OpenIt ();
				} else {
					CloseIt ();
				}
			}
		}
	}

	public void CloseIt(){
		CanTouchFalse ();
		ExitSplash.SetActive(false);
		Time.timeScale = 1;
		Invoke ("CanTouchTrue", WaitSeconds);
//		StartCoroutine ("WaitNextTouch");
//		WaitNextTouch ();
	}
	public void OpenIt(){
		CanTouchFalse ();
		ExitSplash.SetActive (true);
		Invoke ("CanTouchTrue", WaitSeconds);
//		StartCoroutine ("WaitNextTouch");
//		WaitNextTouch ();
	}
//	IEnumerator WaitNextTouch(){
//		yield return new WaitForSeconds(WaitSeconds);
//	}
	public void CanTouchTrue(){
		this.CanTouch = true;
	}
	public void CanTouchFalse(){
		this.CanTouch = false;
	}
}
