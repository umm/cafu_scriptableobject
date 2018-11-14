using System.Collections.Generic;
using CAFU.Core;

namespace CAFU.ScriptableObject.Data.Repository
{
    public interface IScriptableObjectDataStore : IDataStore
    {
        T Get<T>();

        IEnumerable<T> GetList<T>();
    }
}
