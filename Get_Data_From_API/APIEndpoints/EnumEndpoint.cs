using System;
using System.Collections.Generic;
using System.Text;

namespace Money_Forward_Test.APIEndpoints
{
    public static class EnumEndpoint
    {
        public const string GetUserEndpoint = "https://sample-accounts-api.herokuapp.com/users/{0}";
        public const string GetAccountEndpoint = "https://sample-accounts-api.herokuapp.com/users/{0}/accounts";
        public const string GetAccountByIdEndpoint = "https://sample-accounts-api.herokuapp.com/accounts/{0}";
    }
}
