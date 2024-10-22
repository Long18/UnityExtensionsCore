using long18.ExtensionsCore.Events.ScriptableObjects;
using UnityEngine;
using UnityEngine.Events;

namespace long18.ExtensionsCore.Events.ScriptableObjectEventListener
{
    public class VoidEventChannelListener : MonoBehaviour
    {
        [SerializeField] private VoidEventChannelSO _eventSO;

        [SerializeField] private UnityEvent _onEventRaised;

        private void OnEnable()
        {
            if (_eventSO) _eventSO.EventRaised += EventRaised;
        }

        private void OnDisable()
        {
            if (_eventSO) _eventSO.EventRaised -= EventRaised;
        }

        private void EventRaised()
        {
            _onEventRaised.Invoke();
        }
    }
}