namespace FluentApiTests;

public class Validator<TResponse>: IValidator<TResponse>
{
    public async Task<TResponse> ValidateAsync()
    {
        throw new NotImplementedException();
    }
}