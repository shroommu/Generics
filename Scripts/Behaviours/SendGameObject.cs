﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Made By Anthony Romrell
public class SendGameObject : MonoBehaviour
{
	public GameAction Send;

	private void Start()
	{
		Send.Call(gameObject);
	}
}
