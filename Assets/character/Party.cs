using UnityEngine;
using System.Collections;

public class Party : MonoBehaviour {

	public GameObject MoveList;
	public GameObject PokeList;
	public Pokemon[] currentPokemon;
	//public GameObject[] Captured;


	void Start () {
	/*WildPokemon CatchPokemon = PokeList.GetComponent<WildPokemon>();
		currentPokemon [0] = CatchPokemon.CatchablePokemon [0];*/
	}

	void Awake() {
		DontDestroyOnLoad (this);


	}


	void Update () {
	
	}
}
