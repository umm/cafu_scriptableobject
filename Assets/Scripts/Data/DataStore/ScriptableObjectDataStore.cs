using System.Collections.Generic;
using System.Linq;
using CAFU.ScriptableObject.Data.Repository;
using Zenject;

namespace CAFU.ScriptableObject.Data.DataStore
{
    public class ScriptableObjectDataStore : IScriptableObjectDataStore
    {
        [Inject] private IList<UnityEngine.ScriptableObject> ScriptableObjectList { get; set; }

        public T Get<T>()
        {
            return GetList<T>().First();
        }

        public IEnumerable<T> GetList<T>()
        {
            return ScriptableObjectList.OfType<T>();
        }
    }
}
