using CAFU.Core;
using UnityEngine;

namespace CAFU.ScriptableObject.Structure
{
    public interface IKeyValueScriptableObject<out TKey, out TValue> : IStructure
    {
        TKey Key { get; }
        TValue Value { get; }
    }

    public abstract class KeyValueScriptableObject<TKey, TValue> : UnityEngine.ScriptableObject, IKeyValueScriptableObject<TKey, TValue>
    {
        [SerializeField] private TKey key;
        [SerializeField] private TValue value;
        public TKey Key => key;
        public TValue Value => value;
    }
}
