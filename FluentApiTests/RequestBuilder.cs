namespace FluentApiTests;

public class RequestBuilder<TResponse>: IRequestBuilder<TResponse>
{
    public IAssertionsBuilder<TResponse> Request(string path, HttpMethod method)
    {
        return new AssertionsBuilder<TResponse>();
    }
}