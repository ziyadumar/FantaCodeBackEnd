namespace Middleware.Auth{

public class AuthMiddleware{

    private readonly RequestDelegate _next;
    public AuthMiddleware(RequestDelegate next)
    {
        _next=next;

    }
    public async Task Invoke(HTTPContext context)
    {
        if(context.Request.Header.ContainsKey("X.AUthorised"))
        {
            if(context.Request.Header.ContainsKey("X.AUthorised").Equals("false")){

                context.Response.StatusCode= 401;
                return;
            }

        }
        await _next.Invoke(context);


    }



}


}