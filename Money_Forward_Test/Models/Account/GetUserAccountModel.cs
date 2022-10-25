using System;
using System.Collections.Generic;
using System.Text;

namespace Money_Forward_Test.Models.Account
{
    //public class Attributes
    //{
    //    public List<int> id { get; set; }
    //    public int user_id { get; set; }
    //    public string name { get; set; }
    //    public int balance { get; set; }
    //}

    //public class GetUserAccountModel
    //{
    //    public Attributes attributes { get; set; }
    //}

    public class Attributes
    {
        public int id { get; set; }
        public int user_id { get; set; }
        public string name { get; set; }
        public int balance { get; set; }
    }

    public class GetUserAccountModel
    {
        public Attributes attributes { get; set; }
    }
}
