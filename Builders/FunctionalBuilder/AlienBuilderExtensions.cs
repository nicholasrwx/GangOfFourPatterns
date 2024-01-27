public static class AlienBuilderExtensions
{
  public static AlienBuilder WorksAs(this AlienBuilder builder, string position) => builder.Do(p => p.Position = position);
  public static FluentAlienBuilder WorksAs(this FluentAlienBuilder builder, string position) => builder.Do(p => p.Position = position);

}