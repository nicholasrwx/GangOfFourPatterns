
public class EarbudCase : CaseFactory
{

  //Items can come in here and be passed in to local variables
  private EarbudProduct _earbudProductLeft;
  private EarbudProduct _earbudProductRight;

  public EarbudCase(EarbudProduct EarbudProductLeft, EarbudProduct EarbudProductRight)
  {
    this._earbudProductLeft = EarbudProductLeft;
    this._earbudProductRight = EarbudProductRight;
  }

  public override void CaseItems()
  {
    Console.WriteLine("The type of the left earbud is: " + this._earbudProductLeft.type);
    Console.WriteLine("The type of the right earbud is: " + this._earbudProductRight.type);
  }
}