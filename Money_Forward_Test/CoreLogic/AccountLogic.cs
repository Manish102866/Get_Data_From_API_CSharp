using Money_Forward_Test.APIEndpoints;
using Money_Forward_Test.Models.Account;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Money_Forward_Test.CoreLogic
{
    class AccountLogic
    {
        public async Task<GetUserAccountModel> GetAccountById(string Id)
        {
            HttpClient client = new HttpClient();

            var res = await (client.GetAsync(String.Format(EnumEndpoint.GetAccountEndpoint, Id)));

            var result = await res.Content.ReadAsStringAsync();
            GetUserAccountModel am = new GetUserAccountModel();
            am = JsonConvert.DeserializeObject<GetUserAccountModel>(result);
            return am;
        }

        public void PrintAccountToConsole(GetUserAccountModel am)
        {
            Console.WriteLine("====================== Start Printing Account ======================");            
            Console.WriteLine($"Account ID: {am.attributes.id}");
            Console.WriteLine($"User ID: {am.attributes.user_id}");
            Console.WriteLine($"User Name: {am.attributes.name}");
            Console.WriteLine($"User Accounts Balance: {am.attributes.balance}");
            Console.WriteLine("====================== End Printing Account ======================");
        }
    }
}
