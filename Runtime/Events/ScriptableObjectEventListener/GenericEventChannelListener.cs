using long18.ExtensionsCore.Events.ScriptableObjects;
using UnityEngine;
using UnityEngine.Events;

namespace long18.ExtensionsCore.Events.ScriptableObjectEventListener
{
    public abstract class GenericEventChannelListener<TEventChannelSO, TType> : MonoBehaviour
        where TEventChannelSO : GenericEventChannelSO<TType>
    {
        [SerializeField] private TEventChannelSO _eventSO;

        public UnityEvent<TType> _onEventRaised;

        private void OnEnable()
        {
            if (_eventSO) _eventSO.EventRaised += EventRaised;
        }

        private void OnDisable()
        {
            if (_eventSO) _eventSO.EventRaised -= EventRaised;
        }

        private void EventRaised(TType type)
        {
            _onEventRaised.Invoke(type);
        }
    }
}