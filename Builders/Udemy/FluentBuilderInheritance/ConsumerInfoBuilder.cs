public class ConsumerInfoBuilder
{
  public Consumer _consumer = new Consumer();

  public ConsumerInfoBuilder AddConsumerName(string name)
  {
    _consumer._name = name;
    return this;
  }

  public ConsumerInfoBuilder AddOccupation(string occupation)
  {
    _consumer._occupationalHistory.Add(occupation);
    return this;
  }

  public ConsumerInfoBuilder AddRecreation(string recreation)
  {
    _consumer._recreationalHistory.Add(recreation);
    return this;
  }
}