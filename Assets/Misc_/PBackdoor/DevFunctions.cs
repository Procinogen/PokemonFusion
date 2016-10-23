using UnityEngine;
using System.Collections;

public class DevFunctions : MonoBehaviour {


	void Start () {
	
	}
	

	void Update () {
	
	}

	public void LoadControlledBattle(){
	
		Application.LoadLevel ("DevBat");
		//print ("ayy lmao");
	
	}

	public void ExitControlledBattle(){
	
		Application.LoadLevel ("beta");
	
	}
}
