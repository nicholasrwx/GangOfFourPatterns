// SELF is part of the Type declaration that needs to be passed in, this is why the "Builder" class isn't in it's place here
// SELF is constrained to a type that inherits from ConsumerHealthBuilder<SELF>

// Object that inherits from fluent builder
// because the Builder class will be the most derived type that inherits from this class.
// SELF will = Builder
// and when the return value of 'this' is downcasted, it will return the Builder class instead of the ConsumerHealthBuilder<SELF> class

public class ConsumerHealthBuilder<SELF> : ConsumerInfoBuilder<ConsumerHealthBuilder<SELF>> where SELF : ConsumerHealthBuilder<SELF>
{

  public SELF AddConsumableContent(IFoodProducts product)
  {
    foreach (var content in product.Contents)
    {
      _consumer._contentsConsumed.Add(content);
    }

    this.UpdateHealth(product.HealthImpact);

    return (SELF)this;
  }

  public SELF UpdateHealth(int healthIncrement)
  {
    _consumer._health += healthIncrement;
    return (SELF)this;
  }
}
