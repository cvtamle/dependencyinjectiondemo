using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using web.Interface;

namespace web.Models
{
    public class Cart
    {
        private  IDatabase _database;
        private  ILogger _logger;
        private  IEmailSender _emailSender;

        public Cart(IDatabase db, IEmailSender email, ILogger logger)
        {
            _database = db;
            _emailSender = email;
            _logger = logger;
        }

        public void checkout(int orderid, int userid)
        {
            this._database.connectToDB();
            this._logger.log();
            this._emailSender.sendEmail();
        }

    }
}