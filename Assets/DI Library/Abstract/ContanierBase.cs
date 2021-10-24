using System.Collections.Generic;
using SimpleDI;

public abstract class ContanierBase
{
    private List<ContanierItem> contanierItems = new List<ContanierItem>();

    protected List<ContanierItem> ContanierItems { get => contanierItems;}
}