public class ConsumerInfoBuilder
{
  public Consumer consumer = new Consumer();

  public ConsumerInfoBuilder(string name)
  {
    consumer.Name = name;
  }

  public ConsumerInfoBuilder AddOccupation(string occupation)
  {
    consumer.OccupationalHistory.Add(occupation);
    return this;
  }

  public ConsumerInfoBuilder AddRecreation(string recreation)
  {
    consumer.RecreationalHistory.Add(recreation);
    return this;
  }
}