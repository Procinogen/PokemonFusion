using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MoveController : MonoBehaviour {
	public GameObject[] MoveFunc;
	public Text[] MoveTxt;
	public GameObject UserParty;
	public string[] MoveNames;
	public Slider MySlider;
	public Slider TheirSlider;
	public GameObject opponentTemp;
	public InitiateBattle TheScript; 
	public GameObject TempMoveList; //<-- Temp move list.
	public ListOfMoves TheMoveList;
	public Pokemon cPokemon;
	void Start () {


		TempMoveList = GameObject.Find ("Moves");
		UserParty = GameObject.Find ("UserData"); 
		Party holdingPokemon = UserParty.GetComponent<Party>();
		MoveNames [0] = holdingPokemon.currentPokemon [0].Move1.AttackName;
		cPokemon = holdingPokemon.currentPokemon [0];
		MySlider.maxValue = holdingPokemon.currentPokemon [0].Hp;
		MySlider.value = holdingPokemon.currentPokemon [0].CHp;

		//yield return new WaitForSeconds (1);
		StartCoroutine(LoadHealth(0.2f));
		//print (opponent.Name);

	}
		
	void Update () {
		MoveTxt [0].text = MoveNames[0];
	}

	IEnumerator LoadHealth(float i){
		yield return new WaitForSeconds (i);
		TheirSlider.maxValue = TheScript.PokemonToCatch.Hp;
		TheirSlider.value = TheScript.PokemonToCatch.CHp;

	}

	public void UseMove1(){
		print ("test");
		//TheScript.PokemonToCatch.CHp -= cPokemon.Move1.Damage;
		//TheirSlider.value = TheScript.PokemonToCatch.CHp;
	}

}