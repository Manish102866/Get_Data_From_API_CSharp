using System;
using System.Collections.Generic;
using System.Text;

namespace Money_Forward_Test.Models.User
{
    public class Attributes
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<int> account_ids { get; set; }
    }

    public class GetUserModel
    {
        public Attributes attributes { get; set; }
    }
}
