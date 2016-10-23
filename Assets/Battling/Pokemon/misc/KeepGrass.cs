using UnityEngine;
using System.Collections;

public class KeepGrass : MonoBehaviour {

	public Route TG;

	void Awake(){
	
		DontDestroyOnLoad (this);
	
	}

}
