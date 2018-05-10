using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Made By Anthony Romrell
public class TextUI : MonoBehaviour
{
	public InputField DataField;
	public Text DataOutputText;

	public StringData SoData;
	
	public DataStorage NameDataStorage;

	void Start()
	{
		NameDataStorage.GetData();
		DataOutputText.text = SoData.SingleName;
	}

	public void UpdateText()
	{
		SoData.SingleName = DataField.text;
		DataOutputText.text = SoData.SingleName;
		NameDataStorage.SetData();
	}
}