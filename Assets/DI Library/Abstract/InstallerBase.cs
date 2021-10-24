using UnityEngine;
using SimpleDI;

[DefaultExecutionOrder(-10000)]
public abstract class InstallerBase : MonoBehaviour, IInstallerBase
{
    private Contanier contanier = new Contanier();

    public Contanier Contanier { get => contanier; }

    private void Awake()
    {
        InstallBindings();
    }

    public abstract void InstallBindings();
}