using System.Net;

namespace FluentApiTests.Tests;

public class UnitTest1
{
    [Fact]
    public async Task Test1()
    {
        var response = await ApiTest.Configure<ApiResponse>()
            .WithoutAuth()
            .Request("", HttpMethod.Get)
            .StatusCodeShouldBe(HttpStatusCode.Accepted)
            .Then()
            .ValidateAsync();
    }
}