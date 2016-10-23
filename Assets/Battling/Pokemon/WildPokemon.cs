using UnityEngine;
using System.Collections;

public class WildPokemon : MonoBehaviour {

	public Pokemon[] CatchablePokemon;


	void Start () {
	
	}

	void Awake (){
	
		DontDestroyOnLoad (this);
	
	}


	void Update () {
	
	}
}
