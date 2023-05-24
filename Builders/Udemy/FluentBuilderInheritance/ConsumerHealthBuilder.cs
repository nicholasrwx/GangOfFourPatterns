//SELF is part of the Type declaration that needs to be passed in, this is why the "Builder" class isn't in it's place here
//SELF is constrained to a type that inherits from ConsumerHealthBuilder<SELF>

// Object that inherits from fluent builder
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
