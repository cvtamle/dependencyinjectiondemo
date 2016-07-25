using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using web.Interface;

namespace web.Implement
{
    public class DatabaseSQL : IDatabase
    {
        public string connectToDB()
        {
            return "Connected to SQL Database";
        }
    }
}