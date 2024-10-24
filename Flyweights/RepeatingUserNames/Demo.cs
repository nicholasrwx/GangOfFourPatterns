using JetBrains.dotMemoryUnit;

namespace RepeatingUserNames;

[TestFixture]
public class Demo
{

    [Test]
    public void TestUser()
    {
        var firstNames = Enumerable.Range(0, 100).Select(_ => RandomString());
        var lastNames = Enumerable.Range(0, 100).Select(_ => RandomString());

        var users = new List<User>();

        foreach(var firstName in firstNames)
        foreach (var lastName in lastNames)
            users.Add(new User($"{firstName} {lastName}"));

        ForceGC();

        dotMemory.Check(memory =>
        {
            WriteLine(memory.SizeInBytes);
        });
    }

    [Test]
    public void TestUserTwo()
    {
        var firstNames = Enumerable.Range(0, 100).Select(_ => RandomString());
        var lastNames = Enumerable.Range(0, 100).Select(_ => RandomString());

        var users = new List<UserTwo>();

        foreach(var firstName in firstNames)
        foreach (var lastName in lastNames)
            users.Add(new UserTwo($"{firstName} {lastName}"));

        ForceGC();

        dotMemory.Check(memory =>
        {
            WriteLine(memory.SizeInBytes);
        });
    }

    private void ForceGC()
    {
        GC.Collect();
        GC.WaitForPendingFinalizers();
        GC.Collect();
    }

    private string RandomString()
    {
        Random rand = new Random();
        return new string(Enumerable.Range(0, 10).Select(i => (char)('a' + rand.Next(26))).ToArray());
    }
}