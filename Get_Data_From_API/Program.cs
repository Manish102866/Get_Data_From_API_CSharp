using Money_Forward_Test.APIEndpoints;
using Money_Forward_Test.CoreLogic;
using Money_Forward_Test.Models.User;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Money_Forward_Test
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Enter User ID:");
            var uid = Console.ReadLine();
            UserLogic p = new UserLogic();
            var s =await p.GetUserById(uid);
            p.PrintUserToConsole(s);
            AccountLogic acc = new AccountLogic();
            var a = await acc.GetAccountById(uid);
            acc.PrintAccountToConsole(a);
            Console.WriteLine("Enter Account ID:");
            var aid = Console.ReadLine();
            var b = await acc.GetAccount(aid);
            acc.PrintAccountByIdToConsole(b);
        }
        
    }
}
