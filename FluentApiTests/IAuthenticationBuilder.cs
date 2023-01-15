namespace FluentApiTests;

public interface IAuthenticationBuilder<TResponse>
{
    IRequestBuilder<TResponse> WithoutAuth();
    IRequestBuilder<TResponse> WithAuth(AuthenticationOptions options);
    IRequestBuilder<TResponse> WithoutToken(string token);
}