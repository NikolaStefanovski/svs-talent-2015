using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankingClassLibrary.Common;
using BankingClassLibrary.Account;
using BankingClassLibrary.Interfaces;
using BankingClassLibrary.Processors;

namespace BankingApplication
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnCreateTransactionAccount_Click(object sender, EventArgs e)
        {
            decimal limit = decimal.Parse(txtLimit.Text);
            TransactionAccount ta = new TransactionAccount(txtCurrency.Text, limit);
            CurrencyAmount balance = ta.Balance;
            balance.Amount = 300000;
            ta.CreditAmount(balance);
            populateAccountCommonDetails(ta);
            populateTransactionDetails(ta);
        }

        private void populateAccountCommonDetails(IAccount a)
        {
            if (a.GetType().Equals(typeof(TransactionAccount)))
            {
                lblId.Text = a.ID.ToString();
                lblCurrency.Text = a.Currency;
                lblNumber.Text = a.Number;
                lblBalance.Text = a.Balance.Amount.ToString();
            }
            else
            {
                lblIdTo.Text = a.ID.ToString();
                lblCurrencyTo.Text = a.Currency;
                lblNumberTo.Text = a.Number;
                lblBalanceTo.Text = a.Balance.Amount.ToString();
            }
        }

        /// <summary>
        /// Fills labels for transaction account
        /// </summary>
        /// <param name="a"></param>
        private void populateTransactionDetails(IAccount a) 
        {
            if (a.GetType().Equals(typeof(TransactionAccount)))
            {
                TransactionAccount ta = (TransactionAccount)a;
                lblLimit.Text = ta.Limit.Amount.ToString();
            }
            else
            {
                lblLimit.Text = "";
            }
        }

        private void btnCreateDepositAccount_Click(object sender, EventArgs e)
        {
            TimePeriod tp;
            tp.Period = int.Parse(txtPeriodAmount.Text);
            tp.Unit = (UnitOfTime)int.Parse(txtPeriodUnit.Text);
            InterestRate ir;
            ir.Percent = decimal.Parse(txtPercent.Text);
            ir.Unit = (UnitOfTime)int.Parse(txtInterestUnit.Text);
            DateTime start = dtpStartDate.Value;
            DateTime end = dtpEndDate.Value;

            DepositAccount da = new DepositAccount(txtCurrency.Text, tp, ir, start, end, null);
            CurrencyAmount balance = da.Balance;
            balance.Amount = 50000;
            da.CreditAmount(balance);
            populateAccountCommonDetails(da);
            populateDepositDetails(da);
        }

        /// <summary>
        /// Fills labels for deposit account
        /// </summary>
        /// <param name="a"></param>
        private void populateDepositDetails(IAccount a)
        {
            if (a.GetType().Equals(typeof(DepositAccount)))
            {
                DepositAccount da = (DepositAccount)a;
                lblPeriodTo.Text = da.Period.Period.ToString();
                lblPeriodUnitTo.Text = da.Period.Unit.ToString();
                lblPercentTo.Text = da.Interest.Percent.ToString();
                lblInterestUnitTo.Text = da.Interest.Unit.ToString();
                lblStartDateTo.Text = da.StartDate.ToString();
                lblEndDateTo.Text = da.EndDate.ToString();
            }
            else
            {
                lblPeriodTo.Text = "";
                lblPeriodUnitTo.Text = "";
                lblPercentTo.Text = "";
                lblInterestUnitTo.Text = "";
                lblStartDateTo.Text = "";
                lblEndDateTo.Text = "";
            }
        }

        /// <summary>
        /// Transfers funds from one account to another
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMakeTransaction_Click(object sender, EventArgs e)
        {
            long idFrom = long.Parse(lblId.Text);
            string numberFrom = lblNumber.Text;
            decimal currencyFrom = decimal.Parse(lblLimit.Text);
            ITransactionAccount ta = new TransactionAccount(lblCurrency.Text, currencyFrom);
            CurrencyAmount balanceFrom = ta.Balance;
            balanceFrom.Amount = decimal.Parse(lblBalance.Text);
            ta.CreditAmount(balanceFrom);

            //long idTo;

            TimePeriod tp;
            tp.Period = int.Parse(lblPeriodTo.Text);
            tp.Unit = (UnitOfTime)int.Parse(lblPeriodUnitTo.Text);
            InterestRate ir;
            ir.Percent = decimal.Parse(lblPercent.Text);
            ir.Unit = (UnitOfTime)int.Parse(lblInterestUnit.Text);
            string start = lblStartDateTo.Text;
            string end = lblEndDateTo.Text;
            IDepositAccount da = new DepositAccount(lblCurrencyTo.Text, tp, ir, DateTime.Parse(start), DateTime.Parse(end), null);
            CurrencyAmount balanceTo = da.Balance;
            balanceFrom.Amount = decimal.Parse(lblBalanceTo.Text);
            da.CreditAmount(balanceTo);


            CurrencyAmount transferMoney;
            transferMoney.Currency = "MKD";
            transferMoney.Amount = 200000;

            TransactionProcessor processor = new TransactionProcessor();

            processor.ProcessTransaction(TransactionType.Transfer, ta, da, transferMoney);

            populateAccountCommonDetails(ta);
            populateAccountCommonDetails(da);
            populateTransactionDetails(ta);
            populateDepositDetails(da);
        }
    }
}
