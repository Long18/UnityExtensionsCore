using System;
using UnityEngine;

namespace long18.ExtensionsCore.Events.ScriptableObjects
{
    [CreateAssetMenu(fileName = "VoidEvent", menuName = "long18/Extensions Core/Events/Void Event Channel")]
    public class VoidEventChannelSO : ScriptableObject
    {
        public event Action EventRaised;

        public virtual void RaiseEvent() => OnRaiseEvent();

        protected virtual void OnRaiseEvent()
        {
            if (EventRaised == null)
            {
                Debug.LogWarning($"OnRaiseEvent:: No listeners for event {name}.");
                return;
            }

            EventRaised.Invoke();
        }
    }
}