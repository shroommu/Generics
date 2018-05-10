using System.Collections.Generic;
using RoboRyanTron.Unite2017.Events;

namespace AR.Events
{
    public abstract class IGameEvent
    {
        private readonly List<GameEventListener> eventListeners;

        public abstract void Raise();
        public abstract void RegisterListener(GameEventListener listener);
        public abstract void UnregisterListener(GameEventListener listener);
    }
}