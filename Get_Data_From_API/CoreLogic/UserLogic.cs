using Money_Forward_Test.APIEndpoints;
using Money_Forward_Test.Models.User;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Money_Forward_Test.CoreLogic
{
    class UserLogic
    {
        public async Task<GetUserModel> GetUserById(string Id)
        {
            HttpClient client = new HttpClient();

            var res = await (client.GetAsync(String.Format(EnumEndpoint.GetUserEndpoint, Id)));

            var result = await res.Content.ReadAsStringAsync();
            GetUserModel vm = new GetUserModel();
            vm = JsonConvert.DeserializeObject<GetUserModel>(result);
            return vm;
        }

        public void PrintUserToConsole(GetUserModel vm)
        {
            Console.WriteLine("====================== Start Printing User ======================");
            Console.WriteLine($"User ID:{vm.attributes.id}");
            Console.WriteLine($"User Name: {vm.attributes.name}");
            Console.WriteLine($"User Has Following Accounts:");

            foreach (var item in vm.attributes.account_ids)
            {
                Console.WriteLine($"Account ID:{item}");
            }
            Console.WriteLine("====================== End Printing User ======================");
        }
    }
}
