using UnityEngine;

public class MocaDecorator : CoffeeDecorator
{
    public MocaDecorator(ICoffee coffee) : base(coffee)
    {
    }
    public override string Description()
    {
        return coffee.Description() + "Moca";
    }
    public override int Cost()
    {
        return coffee.Cost() + 1000;
    }
}
