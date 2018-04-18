using System;
using UnityEngine;

//Made By Anthony Romrell
[CreateAssetMenu(fileName = "StoreData")]
public class StorePersistantData : ScriptableObject
{

	[SerializeField] public ScriptableObject Objects;

	//private static GameData _instance;
	private const string PlayerPrefsIdentifier = "GameData";

//	public static GameData Instance
//	{
//		get
//		{
//			if (_instance == null)
//			{
//				GameData.GetPlayerPrefs();
//			}
//
//			return _instance;
//		}
//	}

	public void GetPlayerPrefs()
	{
//		if (string.IsNullOrEmpty(PlayerPrefs.GetString(PlayerPrefsIdentifier)))
//		{
//			Objects = ScriptableObject.CreateInstance<ScriptableObject>();
//		}
//		else
//		{
			Objects = JsonUtility.FromJson<ScriptableObject>(PlayerPrefs.GetString(PlayerPrefsIdentifier));
//		}
		Debug.Log(Objects);
	}

	public void SetPlayerPrefs()
	{
		PlayerPrefs.SetString(PlayerPrefsIdentifier, JsonUtility.ToJson(Objects));
		Debug.Log(Objects);
	}

	private void OnDisable()
	{
		SetPlayerPrefs();
	}
}