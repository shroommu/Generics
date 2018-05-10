using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DataStorage", menuName = "Data Storage/String List")]
public class StringData : ScriptableObject
{
	public string SingleName;

	public List<string> NameList;

}