using UnityEngine;
using System.Collections;

public class KeepPokemonLoaded : MonoBehaviour {

	void Awake(){
	
		DontDestroyOnLoad (this);
	
	}
}
