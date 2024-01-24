namespace Controllers.Animals;

public static class AnimalsController
{
  public static RouteGroupBuilder MapAnimalsApi(this RouteGroupBuilder group)
  {
    group.MapGet("/", GetAllTodos);
    // group.MapGet("/{id}", GetTodo);
    // group.MapPost("/", CreateTodo);
    // group.MapPut("/{id}", UpdateTodo);
    // group.MapDelete("/{id}", DeleteTodo);

    return group;
  }

  public static void GetAllTodos(HttpContext context)
  {
    context.Response.WriteAsync("Hello World!");
  }
}
