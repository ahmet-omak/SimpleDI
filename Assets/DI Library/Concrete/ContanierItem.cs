using System;

namespace SimpleDI
{
    [Serializable]
    public class ContanierItem
    {
        public object Instance { get; set; }
        public Type InstanceType { get; set; }

        public ContanierItem(object instance)
        {
            Instance = instance;
            InstanceType = instance.GetType();
        }
    }
}