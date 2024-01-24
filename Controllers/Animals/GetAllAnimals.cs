namespace Controllers.Animals;

public static partial class AnimalsController
{
  public static void GetAllAnimals(HttpContext context)
  {
    context.Response.WriteAsync("Hello World!");
  }
}
