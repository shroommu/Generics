using System.Collections.Generic;
using RoboRyanTron.Unite2017.Events;
using UnityEngine;

namespace AR.Events
{
    public class GameEventObject: ScriptableObject
    {
        private readonly List<GameEventObjectListener<object>> eventListeners = 
            new List<GameEventObjectListener<object>>();

        public void Raise()
        {
            for(int i = eventListeners.Count -1; i >= 0; i--)
                eventListeners[i].OnEventRaised();
        }

        public void RegisterListener(GameEventObjectListener<object> listener)
        {
            if (!eventListeners.Contains(listener))
                eventListeners.Add(listener);
        }

        public void UnregisterListener(GameEventObjectListener<object> listener)
        {
            if (eventListeners.Contains(listener))
                eventListeners.Remove(listener);
        }

    }
}