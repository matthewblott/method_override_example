using Microsoft.AspNetCore.Builder;

namespace method_override_example
{
  public static class MyMiddlewareExtensions
  {
    public static IApplicationBuilder UseMyMiddleware(this IApplicationBuilder builder) =>
      builder.UseMiddleware<MyMiddleware>();

  }

}
