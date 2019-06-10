using System.Collections.Generic;
using CAFU.ScriptableObject.Domain.UseCase.Interface;
using Zenject;

namespace CAFU.ScriptableObject.Data.Repository
{
    public class ScriptableObjectRepository : IScriptableObjectRepository
    {
        [Inject] private IScriptableObjectDataStore ScriptableObjectDataStore { get; set; }

        public T Get<T>()
        {
            return ScriptableObjectDataStore.Get<T>();
        }

        public IEnumerable<T> GetList<T>()
        {
            return ScriptableObjectDataStore.GetList<T>();
        }
    }
}
