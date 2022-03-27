namespace ExnCars.Web.Middlewares
{
  public class NoMaliciousQueryStringsMiddleware
  {
    private readonly RequestDelegate _next;

    public NoMaliciousQueryStringsMiddleware(RequestDelegate _next)
    {
      this._next = _next;
    }

    public async Task InvokeAsync(HttpContext context)
    {
      if (context.Request.QueryString.Value.Contains("role=admin"))
      {
        await context.Response.WriteAsync("UNAUTHORIZED!!!!!");
        return;
      }

      await _next(context); // continui executia pipeline-ului
    }
  }
}
