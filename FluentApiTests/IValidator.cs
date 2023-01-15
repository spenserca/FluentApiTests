namespace FluentApiTests;

public interface IValidator<TResponse>
{
    Task<TResponse> ValidateAsync();
}