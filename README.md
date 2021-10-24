## Simple DI

### Introduction
It's a lightweight  <a href="https://en.wikipedia.org/wiki/Dependency_injection#:~:text=In%20software%20engineering%2C%20dependency%20injection,it%20depends%20on%2C%20called%20dependencies.&text=The%20intent%20behind%20dependency%20injection,increase%20readability%20and%20code%20reuse.">Dependency Injection</a> Library built specifically to target Unity 3D

### Features
- Supports both MonoBehaviours and normal C# classes
- Exception handling using its own logging system


### Binding
In SimpleDI, dependency mapping is done by adding bindings to something called contanier. Contanier is basically nothing but an empty (at startup) list of objects that hold references. With SimpleDI you can manage the bindings like in the example below, by creating a MonoBehaviour and letting it inherit from InstallerBase. After that, all you have to do is to override The "InstallBindings" method and use it to bind.

```csharp
    public class Installer : InstallerBase
    {
        public override void InstallBindings()
        {
            Contanier.BindMonoInstance(FindObjectOfType<SoundController>());
            Contanier.BindInstance(new NoneMonoBehaviourClass());
        }
    }
```

### Resolving
Unfortunately, SimpleDI doesn't resolve instances automatically or support Inject attribute like <a href="https://github.com/modesttree/Zenject">Zenject</a>. You have to do the resolving on your own. But, As shown below it's not as hard as it sounds.

1 - **Resolve Through Classes**
```csharp
public class GameManager : MonoBehaviour
{
    private PlayerController playerController;

    private void Awake()
    {
        var Contanier = FindObjectOfType<Installer>().Contanier;

        playerController = Contanier.Resolve<PlayerController>();
    }

    private void Update()
    {
        playerController.Move();
    }
}
```

2 - **Resolve Through Interfaces**
```csharp
public class GameManager : MonoBehaviour
{
    private ISoundController soundController;
    
    private void Awake()
    {
        var Contanier = FindObjectOfType<Installer>().Contanier;

        soundController = Contanier.Resolve<SoundController>();
    }
    
    private void Start()
    {
        soundController.Play();
    }
}
```
