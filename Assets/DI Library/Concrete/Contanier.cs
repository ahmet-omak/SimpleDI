using SimpleDI.Log;
using UnityEngine;
using System;

namespace SimpleDI
{
    public class Contanier : ContanierBase, IContanier
    {
        public void BindMonoInstance<TMonoContract>(TMonoContract monoContract) where TMonoContract : MonoBehaviour
        {
            Type contractType = monoContract.GetType();
            if (CanBind(contractType))
            {
                new BindFailed();
                return;
            }
            var contanierInfo = new ContanierItem(monoContract);
            ContanierItems.Add(contanierInfo);
            new SuccessBind();
        }

        public void BindInstance<TContract>(TContract contract) where TContract : new()
        {
            Type contractType = contract.GetType();
            if (CanBind(contractType))
            {
                new BindFailed();
                return;
            }
            var newContract = new TContract();
            var contanierInfo = new ContanierItem(newContract);
            ContanierItems.Add(contanierInfo);
            new SuccessBind();
        }

        public TInstance Resolve<TInstance>() where TInstance : class, new()
        {
            foreach (var contanierItem in ContanierItems)
            {
                if (contanierItem.InstanceType == typeof(TInstance))
                {
                    return (TInstance)contanierItem.Instance;
                }
            }
            new ResolveFailed();
            return default;
        }

        private bool CanBind(Type instanceType)
        {
            foreach (var contanierItem in ContanierItems)
            {
                if (contanierItem.InstanceType == instanceType)
                {
                    return true;
                }
            }
            return false;
        }
    }
}