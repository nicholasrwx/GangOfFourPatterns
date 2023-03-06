//Object that inherits from fluent builder
public class ConsumerHealthBuilder : ConsumerInfoBuilder
{

  public ConsumerHealthBuilder AddConsumableContent(string content)
  {
    _consumer._contentsConsumed.Add(content);
    return this;
  }

  public ConsumerHealthBuilder UpdateHealth(int healthIncrement)
  {
    _consumer._health += healthIncrement;
    return this;
  }
}