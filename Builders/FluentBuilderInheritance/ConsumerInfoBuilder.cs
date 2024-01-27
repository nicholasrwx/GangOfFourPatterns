public class ConsumerInfoBuilder<SELF> : ConsumerBuilder where SELF : ConsumerInfoBuilder<SELF>
{

  public SELF AddConsumerName(string name)
  {
    _consumer._name = name;
    return (SELF)this;
  }

  public SELF AddOccupation(string occupation)
  {
    _consumer._occupationalHistory.Add(occupation);
    return (SELF)this;
  }

  public SELF AddRecreation(string recreation)
  {
    _consumer._recreationalHistory.Add(recreation);
    return (SELF)this;
  }
}