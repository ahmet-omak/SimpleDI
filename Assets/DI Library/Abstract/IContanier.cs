using UnityEngine;

public interface IContanier
{
    void BindMonoInstance<TMonoContract>(TMonoContract monoContract) where TMonoContract : MonoBehaviour;
    void BindInstance<TContract>(TContract contract) where TContract : new();
    TInstance Resolve<TInstance>() where TInstance : class, new();
}