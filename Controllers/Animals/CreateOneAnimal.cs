namespace Controllers.Animals;

using System.Text.Json;
using Data;
using Models;

public static partial class AnimalsController
{
  public static async Task<IResult> CreateOneAnimal(
    Animal animal,
    HttpContext context,
    AppDbContext db
  )
  // public static void CreateOneAnimal(Animal animal)
  {
    try
    {
      // Console.WriteLine(animal);

      // context.Request.EnableBuffering();

      // var body = await new StreamReader(context.Request.Body, Encoding.UTF8).ReadToEndAsync();

      // Console.WriteLine($"Request body: {body}");

      // var animal = await body.ReadToEndAsync();

      Console.WriteLine(JsonSerializer.Serialize(animal));

      // var newAnimal = new Animal { Name = animal.Name };
      // var newCountry = new Country { Name = animal.Country.Name };

      // db.Countries.Add(new Country { Name = "testCountry", });
      // db.Animals.Add(new Animal { Name = "testAnimal", });
      db.Animals.Add(animal);
      await db.SaveChangesAsync();

      // await context.Response.WriteAsync("Hello World!");
      // await context.Response.WriteAsJsonAsync(body);
      return Results.Created();
    }
    catch (Exception ex)
    {
      Console.WriteLine(ex.Message);
      return Results.BadRequest(ex.Message);
    }
  }
}
