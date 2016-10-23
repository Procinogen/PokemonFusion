using UnityEngine;
using System.Collections;

public class ListOfMoves : MonoBehaviour {
	//public string[] Moves;
	public Moves[] Turns;
	//public GameObject PlayerParty;




	void Start () {
	
	}

	void Awake() {
		DontDestroyOnLoad (this);
	}
	

	void Update () {
	
	}
}
