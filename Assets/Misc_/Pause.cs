using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour {

	public GameObject pausing;
	public bool paused = false;
	public GameObject daPlaya;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.Escape)  && paused == false) {

			paused = true;
			Time.timeScale = 0;
			pausing.SetActive (true);


		} else  if (Input.GetKeyDown (KeyCode.Escape)){

			paused = false;
			Time.timeScale = 1;
			pausing.SetActive (false);

		
		}

}

}