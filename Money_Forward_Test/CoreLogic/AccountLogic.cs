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
        public async Task<List<GetUserAccountModel>> GetAccountById(string Id)
        {
            HttpClient client = new HttpClient();

            var res = await (client.GetAsync(String.Format(EnumEndpoint.GetAccountEndpoint, Id)));

            var result = await res.Content.ReadAsStringAsync();
             List < GetUserAccountModel > am = new  List<GetUserAccountModel>();
            am = JsonConvert.DeserializeObject<List<GetUserAccountModel>>(result);
            
           
            return am;
        }

        public void PrintAccountToConsole(List<GetUserAccountModel> am)
        {
           foreach(var item in am)
            {
              
                    Console.WriteLine("====================== Start Printing Account ======================");
                    Console.WriteLine($"Account ID: {item.attributes.id}");
                    Console.WriteLine($"User ID: {item.attributes.user_id}");
                    Console.WriteLine($"User Name: {item.attributes.name}");
                    Console.WriteLine($"User Accounts Balance: {item.attributes.balance}");
                    Console.WriteLine("====================== End Printing Account ======================");
            }
        }

        public async Task<GetUserAccountModel> GetAccount(string Id)
        {
            HttpClient client = new HttpClient();
            var res = await (client.GetAsync(String.Format(EnumEndpoint.GetAccountByIdEndpoint, Id)));
            var result = await res.Content.ReadAsStringAsync();
            GetUserAccountModel am = new GetUserAccountModel();
            am = JsonConvert.DeserializeObject<GetUserAccountModel>(result);
            return am;
        }

        public void PrintAccountByIdToConsole(GetUserAccountModel am)
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
