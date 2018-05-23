using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "PlayerHealth")]
public class Health : ScriptableObject
{
	[Range(0, 1)] public float HealthValue;
	
	public Image HealthBarImage;
	
	public GameAction HealthAction;
	public GameAction EndGameAction;
	
	private void OnEnable()
	{
		HealthAction.Call += HealthActionHandler;
	}

	void HealthActionHandler(object obj)
	{
		HealthBarImage = obj as Image;
	}

	void UpdateHealth(float powerLevel)
	{
		HealthBarImage.fillAmount += powerLevel;
		
		if (HealthBarImage.fillAmount < 0)
		{
			EndGameAction.CallNoArgs();
		}
	}
}
