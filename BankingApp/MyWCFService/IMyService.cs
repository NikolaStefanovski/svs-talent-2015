using BankingClassLibrary.Account;
using BankingClassLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace MyWCFService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IMyService
    {

        [OperationContract]
        AccountService GetAccountBalance(AccountService account);
    }

    [DataContract]
    public class AccountService
    {
        Account _account;

        [DataMember]
        public Account TheAccount 
        {
            get { return _account; }
            set { _account = value; }
        }
    }
}
