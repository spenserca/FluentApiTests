using System.Net;

namespace FluentApiTests;

public interface IAssertionsBuilder<TResponse>
{
    IAssertionsBuilder<TResponse> StatusCodeShouldBe(HttpStatusCode statusCode);

    IValidator<TResponse> Then();
}