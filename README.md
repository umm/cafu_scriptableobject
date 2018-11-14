# CAFU ScriptableObject

## What

* Handle ScriptableObject for CAFU v3

## Requirement

* CAFU Core v3
* Zenject

## Install

```shell
yarn add "umm/cafu_scriptableobject#^1.0.0"
```

## Usage
### Key(Value|List)ScriptableObject を継承したクラスを作成する

```csharp
using CAFU.ScriptableObject.Structure;
using ScriptableObjectSample.Application.Enumerate;
using UnityEngine;

namespace ScriptableObjectSample
{
    [CreateAssetMenu(menuName = "Master/Avatar")]
    public class Avatar : KeyValueScriptableObject<AvatarType, Sprite>
    {
    }
}
```

### 作成したクラスのScriptableObjectを作成する
* `Project` view にて上記例だと `Create > Master > AvaterFace`


### ScriptableObjectInstaller を作成する
* `Project` view にて `Installer > ScriptableObjectInstaller`
* `Scriptable Object List` に生成したScriptableObjectを設定する

### SceneContextの設定
* ScriptableObjectを読み込みたいSceneの任意のGameObjectに `SceneContext` をアタッチする
* `SceneContext` の `Scriptable Object Installer` に生成した `ScriptableObjectInstaller` を指定する

### ScriptableObject を呼び出す

```csharp
using System.Linq;
using CAFU.Core;
using CAFUScriptableObject.Scripts.Domain.UseCase.Interface;
using Zenject;

namespace ScriptableObjectSample
{
    public class AvatarTranslator : ITranslator<AvatarType, IAvatarStructure>
    {
        [Inject] private IScriptableObjectRepository ScriptableObjectRepository { get; set; }

        public IAvatarStructure Translate(AvatarType type)
        {
            return
                new AvatarStructure(
                    ScriptableObjectRepository.GetList<Avatar>().First(x => x.Key == type).Value
                );
        }
    }
}
```

## License

Copyright (c) 2018 Tetsuya Mori

Released under the MIT license, see [LICENSE.txt](LICENSE.txt)
