using System.Net;

namespace FluentApiTests;

public class AssertionsBuilder<TResponse> : IAssertionsBuilder<TResponse>
{
    public IAssertionsBuilder<TResponse> StatusCodeShouldBe(HttpStatusCode statusCode)
    {
        throw new NotImplementedException();
    }

    public IValidator<TResponse> Then()
    {
        return new Validator<TResponse>();
    }
}