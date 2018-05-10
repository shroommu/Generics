using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using Object = System.Object;

[CreateAssetMenu(menuName = "Actions/Game Action")]
public class GameAction : ScriptableObject
{
	public UnityAction<object> Call;
	public UnityAction CallNoArgs;
	
	//Overloading
	public void ActionCall()
	{
		CallNoArgs();
	}
	
	public void ActionCall(Object obj)
	{
		Call(obj);
	}
}