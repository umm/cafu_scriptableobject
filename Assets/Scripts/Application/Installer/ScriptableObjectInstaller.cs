using System.Collections.Generic;
using CAFU.ScriptableObject.Data.DataStore;
using CAFU.ScriptableObject.Data.Repository;
using UnityEngine;

namespace CAFU.ScriptableObject.Application.Installer
{
    [CreateAssetMenu(menuName = "Installer/ScriptableObjectInstaller")]
    public class ScriptableObjectInstaller : Zenject.ScriptableObjectInstaller
    {
        [SerializeField] private List<UnityEngine.ScriptableObject> scriptableObjectList;
        private List<UnityEngine.ScriptableObject> ScriptableObjectList => scriptableObjectList;

        public override void InstallBindings()
        {
            Container.Bind<IList<UnityEngine.ScriptableObject>>().FromInstance(ScriptableObjectList).AsCached();
            Container.BindInterfacesTo<ScriptableObjectDataStore>().AsCached();
            Container.BindInterfacesTo<ScriptableObjectRepository>().AsCached();
        }
    }
}
