using UnityEngine.Events;

public class TextActionHandler : GameActionHandler
{
	public UnityEvent<string> Event;

	protected override void Respond (object obj)
	{
		Event.Invoke((string) obj);
	}
}