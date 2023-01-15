namespace FluentApiTests;

public class AuthenticationBuilder<TResponse>: IAuthenticationBuilder<TResponse>
{
    public IRequestBuilder<TResponse> WithoutAuth()
    {
        return new RequestBuilder<TResponse>();
    }

    public IRequestBuilder<TResponse> WithAuth(AuthenticationOptions options)
    {
        return new RequestBuilder<TResponse>();
    }

    public IRequestBuilder<TResponse> WithoutToken(string token)
    {
        return new RequestBuilder<TResponse>();
    }
}