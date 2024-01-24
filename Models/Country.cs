namespace Models;

public class Country
{
  public Guid Id { get; set; }

  public string Name { get; set; }

  public List<Animal> Animals { get; set; }
}
