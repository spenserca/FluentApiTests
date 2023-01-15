using System.Reflection.Emit;

namespace FluentApiTests;

public class ApiTest
{
    private ApiTest()
    {
        
    }

    public static IAuthenticationBuilder<TResponse> Configure<TResponse>()
    {
        return new AuthenticationBuilder<TResponse>();
    }
}