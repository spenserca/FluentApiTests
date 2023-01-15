namespace FluentApiTests;

public interface IRequestBuilder<TResponse>
{
    IAssertionsBuilder<TResponse> Request(string path, HttpMethod method);
}