public class Employee : Person, IDeepCopyable<Employee>
{
    public int Salary;

    public Employee()
    {
        
    }

    public Employee(string[] names, Address address, int salary) : base(names, address)
    {
        Salary = salary;
    }

    public void CopyTo(Employee target)
    {
        base.CopyTo(target);
        target.Salary = Salary;
    }

    //  public Employee DeepCopy()
    //  {
    //      return new Employee((string[]) Names.Clone(), Address.DeepCopy(), Salary);
    //  }

    public override string ToString()
    {
        return $"{base.ToString()}, {nameof(Salary)}: {Salary}";
    }
}