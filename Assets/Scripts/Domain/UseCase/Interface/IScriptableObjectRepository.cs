using System.Collections.Generic;
using CAFU.Core;

namespace CAFU.ScriptableObject.Domain.UseCase.Interface
{
    public interface IScriptableObjectRepository : IRepository
    {
        T Get<T>();

        IEnumerable<T> GetList<T>();
    }
}
