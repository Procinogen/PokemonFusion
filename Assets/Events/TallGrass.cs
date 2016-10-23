using UnityEngine;
using System.Collections;

public class TallGrass : MonoBehaviour {



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void Awake () {
	

	
	}


	void OnTriggerExit (Collider Player){

		float Attacked = Random.Range (1, 100);
	

		if (Attacked > 96) {
			Application.LoadLevel ("battlebeta");
		}


	
	}

}
