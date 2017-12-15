using Microsoft.AspNetCore.Builder;
using Middleware.Auth;


namespace Middleware.Extensions{

public static class AuthMiddlewwareExtension{

public static IApplicationBuilder UseAuthMiddleware(this.IApplicationBuilder builder)
{
return builder.UseAuthMiddleware<UseAuthMiddleware>();

}


}




}