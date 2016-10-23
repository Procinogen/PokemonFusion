using UnityEngine;
using System.Collections;

[System.Serializable]

public class Moves{

	public string AttackName;
	public float Damage;
	public float Accuracy;
	public float RegPP;
	public float CurPP;
	public int LrnLvl;
	public StatusEffect[] StatEff;
	//public Pokemon Target;
}


public enum StatusEffect{

	None,
	Poison,
	Burn, //ROASTED
	Frozen,
	Sleep,
	LowerDef,
	LowerAtk,
	SharplyLowerDef,
	SharplyLowerAtk,
	RaiseDef,
	RaiseAtk,
	SharplyRaiseDef,
	SharplyRaiseAtk

}

public enum TargetPok{

	Self,
	Opponent
}