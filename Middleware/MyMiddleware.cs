using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.Linq;

// https://www.hanselman.com/blog/HTTPPUTOrDELETENotAllowedUseXHTTPMethodOverrideForYourRESTServiceWithASPNETWebAPI.aspx
namespace method_override_example
{
  public class MyMiddleware
  {
    readonly RequestDelegate _next;

    public MyMiddleware(RequestDelegate next) => _next = next;

    public async Task Invoke(HttpContext context)
    {
      if(context.Request.Method == HttpMethods.Post)
      {
        var q =
          from x in context.Request.Form
          where x.Key == "_method" && x.Value.Any()
          select x.Value[0];

        if(q.Any())
        {
          context.Request.Method = q.First();
        }

      }

      await _next.Invoke(context);

    }

  }

}