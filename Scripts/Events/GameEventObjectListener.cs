using RoboRyanTron.Unite2017.Events;
using UnityEngine;
using UnityEngine.Events;

namespace AR.Events
{
    public class GameEventObjectListener<T> : MonoBehaviour
    {
        [Tooltip("Event to register with.")]
        public GameEventObject Event;

        [Tooltip("Response to invoke when Event is raised.")]
        public UnityEvent<T> Response;

        private void OnEnable()
        {
           // Event.RegisterListener(this);
        }

        private void OnDisable()
        {
           // Event.UnregisterListener(this);
        }

        public void OnEventRaised()
        {
            Response.Invoke(default(T));
        }
    }
}