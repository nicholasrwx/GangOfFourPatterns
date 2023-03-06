//Object that inherits from fluent builder
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