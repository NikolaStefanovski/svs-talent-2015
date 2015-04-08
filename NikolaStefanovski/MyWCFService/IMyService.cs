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
        /// <summary>
        /// Makes big letters small!
        /// </summary>
        /// <param name="sBuilder"></param>
        /// <returns></returns>
        [OperationContract]
        StringMagic DoSomeMagicToString(StringMagic sBuilder);

        [OperationContract]
        string GetAccountBalance(IAccount account);
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class StringMagic
    {
        bool _small = true;
        string _stringValue = "";

        [DataMember]
        public bool Small 
        {
            get { return _small; }
            set { _small = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return _stringValue; }
            set { _stringValue = value; }
        }
    }
}
