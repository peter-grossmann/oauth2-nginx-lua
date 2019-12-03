using IdentityServer.LdapExtension.Extensions;
using IdentityServer.LdapExtension.UserModel;
using Novell.Directory.Ldap;
using System.Security.Claims;
using IdentityModel;
using System;

namespace IdServer
{
    public interface IUserStore
    {
        User ValidateCredentials(string user, string password);
    }
}