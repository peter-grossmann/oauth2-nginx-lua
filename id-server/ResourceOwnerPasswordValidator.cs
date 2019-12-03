using IdentityServer4.Validation;
using System.Threading.Tasks;
using System.Security.Claims;


public class ResourceOwnerPasswordValidator : IResourceOwnerPasswordValidator
{

    /* public async Task ValidateAsync(string userName, string password, ValidatedTokenRequest request)
    {
        return new Task(new GrantValidationResult(
            subject: userName,
            authenticationMethod: "",
            claims: new[] { new Claim("name", "whatever") }));
    } */
    public async Task ValidateAsync(ResourceOwnerPasswordValidationContext context)
    {
        var userName = context.UserName;
        var password = context.Password;

        context.Result = new GrantValidationResult(
            subject: userName,
            authenticationMethod: "",
            claims: new[] { new Claim("name", "whatever") });
        //return new Task(context.Result);
    }
}