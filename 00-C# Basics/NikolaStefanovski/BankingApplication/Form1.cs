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
using BankingClassLibrary.Accounts;

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
            populateAccountCommonDetails(ta);
            populateTransactionDetails(ta);
        }

        private void populateAccountCommonDetails(Account a)
        {
            lblId.Text = a.ID.ToString();
            lblCurrency.Text = a.Currency;
            lblNumber.Text = a.Number;
            lblBalance.Text = a.Balance.Amount.ToString();
        }

        private void populateTransactionDetails(Account a) 
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
            populateAccountCommonDetails(da);
            populateDepositDetails(da);
        }

        private void populateDepositDetails(Account a)
        {
            if (a.GetType().Equals(typeof(DepositAccount)))
            {
                DepositAccount da = (DepositAccount)a;
                lblPeriod.Text = da.Period.Period.ToString();
                lblPeriodUnit.Text = da.Period.Unit.ToString();
                lblPercent.Text = da.Interest.Percent.ToString();
                lblInterestUnit.Text = da.Interest.Unit.ToString();
                lblStartDate.Text = da.StartDate.ToString();
                lblEndDate.Text = da.EndDate.ToString();
            }
            else
            {
                lblPeriod.Text = "";
                lblPeriodUnit.Text = "";
                lblPercent.Text = "";
                lblInterestUnit.Text = "";
                lblStartDate.Text = "";
                lblEndDate.Text = "";
            }
        }
    }
}
