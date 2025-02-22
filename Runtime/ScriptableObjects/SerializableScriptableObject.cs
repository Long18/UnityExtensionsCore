using UnityEngine;
using long18.ExtensionsCore.EditorTools;

#if UNITY_EDITOR
using UnityEditor;
#endif

namespace long18.ExtensionsCore.ScriptableObjects
{
    /// <summary>
    /// Use when you want guid of scriptable object for saving it.
    /// </summary>
    public class SerializableScriptableObject : ScriptableObject
    {
        [SerializeField, ReadOnly] private string _guid;
        public string Guid => _guid;

#if UNITY_EDITOR
        protected virtual void OnValidate()
        {
            var assetPath = AssetDatabase.GetAssetPath(this);
            _guid = AssetDatabase.AssetPathToGUID(assetPath);
        }
#endif
    }
}