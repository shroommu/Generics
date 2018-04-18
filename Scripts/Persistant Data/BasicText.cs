using UnityEngine;
using UnityEngine.UI;

public class BasicText : MonoBehaviour 
{
	public string MyText;
	public InputField OutgoingText;
	public Text IncomingText;
	

	private void OnEnable()
	{
		IncomingText.text = OutgoingText.text;
	}

	public string MyTextProperty
	{
		get
		{
			return MyText; 	
		}
		set
		{
			MyText = value; 
			OnEnable();
		}
	}
}