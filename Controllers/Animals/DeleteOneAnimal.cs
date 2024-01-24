namespace Controllers.Animals;

public static partial class AnimalsController
{
  public static void DeleteOneAnimal(string id, HttpContext context)
  {
    Console.WriteLine(id);
    context.Response.WriteAsync("Hello World!");
  }
}
