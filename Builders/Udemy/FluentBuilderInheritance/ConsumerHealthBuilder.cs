//Object that inherits from fluent builder
public class ConsumerHealthBuilder : ConsumerInfoBuilder
{
  public ConsumerHealthBuilder(string name) : base(name)
  {
  }

  public ConsumerHealthBuilder AddConsumableContent(string content)
  {
    consumer.ContentsConsumed.Add(content);
    return this;
  }

  public ConsumerHealthBuilder UpdateHealth(int healthIncrement)
  {
    consumer.Health += healthIncrement;
    return this;
  }
}