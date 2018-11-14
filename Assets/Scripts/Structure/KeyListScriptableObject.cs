using System.Collections.Generic;
using CAFU.Core;
using UnityEngine;

namespace CAFU.ScriptableObject.Structure
{
    public interface IKeyListScriptableObject<out TKey, TValue> : IStructure
    {
        TKey Key { get; }
        IList<TValue> List { get; }
    }

    public abstract class KeyListScriptableObject<TKey, TValue> : UnityEngine.ScriptableObject, IKeyListScriptableObject<TKey, TValue>
    {
        [SerializeField] private TKey key;
        [SerializeField] private List<TValue> list;
        public TKey Key => key;
        public IList<TValue> List => list;
    }
}
