public static class AlienBuilderExtensions
{
  public static AlienBuilder WorksAs(this AlienBuilder builder, string position) => builder.Do(position => p.Position = position);
}