using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class InitiateBattle : MonoBehaviour {

	public GameObject UserParty; 
	public GameObject NativePokemon;
	public GameObject GrassIni;
	public Pokemon PokemonToCatch;
	List<Pokemon> AvaliablePkmn = new List<Pokemon>();

	void Start () {
		UserParty = GameObject.Find ("UserData");
		NativePokemon = GameObject.Find ("PokemonController");
		GrassIni = GameObject.Find ("Grass");


		Party holdingPokemon = UserParty.GetComponent<Party>();
		WildPokemon PokemonEncounter = NativePokemon.GetComponent<WildPokemon>();
		KeepGrass GrassDat = GrassIni.GetComponent<KeepGrass>();
		//print (PokemonEncounter.CatchablePokemon [0].Name );
		holdingPokemon.currentPokemon [0].Model.transform.position = new Vector3 (23, 0.1f, 0);
		holdingPokemon.currentPokemon [0].Model.transform.Rotate(0, 34, 0);
		GrassIni.transform.position = new Vector3 (0, -100f, 0);

		//print (PokemonEncounter.CatchablePokemon [0].Name);
		//print (PokemonEncounter.CatchablePokemon [0].Find);
		//print (GrassDat.TG);



		for (int i = 0; i < 4; i++){
			//print (i);
			if (PokemonEncounter.CatchablePokemon [i].Find == GrassDat.TG){
				print (PokemonEncounter.CatchablePokemon [i].Name);
				AvaliablePkmn.Add (PokemonEncounter.CatchablePokemon [i]);
				//AvaliablePkmn [i] = PokemonEncounter.CatchablePokemon [i];

			}
				
			}
			
		print (AvaliablePkmn.Count);
		int number = Random.Range(0, (AvaliablePkmn.Count + 1));
		PokemonToCatch = AvaliablePkmn [number];
		print	("PokemonToCatchName:" + PokemonToCatch.Name);
		//print	(PokemonToCatch.Model);
		PokemonToCatch.Model.transform.position = new Vector3 (30, 0, 5);
		PokemonToCatch.Model.transform.Rotate (0, 250, 0);
	}

	void Awake (){
		

	
	}
		
	

	void Update () {
	
	}
}
