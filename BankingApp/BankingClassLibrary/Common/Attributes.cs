using System;
namespace BankingClassLibrary.Common {

    [AttributeUsage(AttributeTargets.Class)]
    public class AccountMetadataAttribute : System.Attribute
    {
        private string _accountDescription;

        public string AccountDescription
        {
            get { return _accountDescription; }
            set { _accountDescription = value; }
        }

        private string _accountLimitations;

        public string AccountLimitations
        {
            get { return _accountLimitations; }
            set { _accountLimitations = value; }
        }
    }

    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
    public class FormatRestrictionAttribute : System.Attribute
    {
        private string _formatString;
                
        public string FormatString
        {
            get { return _formatString; }
            set { _formatString = value; }
        }

        private int _maxLength;

        public int MaxLength
        {
            get { return _maxLength; }
            set { _maxLength = value; }
        }
    }
}