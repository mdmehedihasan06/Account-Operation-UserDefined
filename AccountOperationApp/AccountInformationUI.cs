using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountOperationApp
{
    public partial class AccountInformationUI : Form
    {
        Account account = new Account();
        double amount;

        public AccountInformationUI()
        {
            InitializeComponent();
        }

        private void accountCreateButton_Click(object sender, EventArgs e)
        {
            account.accountNo = accountNoTextBox.Text;
            account.name = holdersNameTextBox.Text;
            MessageBox.Show(account.name + ", your account has been created successfully!");
        }

        private void depositeButton_Click(object sender, EventArgs e)
        {
            amount = Convert.ToDouble(amountTextBox.Text);
            account.Deposit(amount);
            MessageBox.Show("Yous amount is deposited successfully!");
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            amount = Convert.ToDouble(amountTextBox.Text);
            account.Withdraw(amount);
            MessageBox.Show("You have successfully withdrawn your amount.");
        }

        private void showReportButton_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(account.name + ", your account number is: " + account.accountNo +" and current balance is TK "+ account.balance);
            MessageBox.Show("Name: " + account.name + "\n Account number: " + account.accountNo + "\n Current balance: " + account.balance + " TK");
        }
    }
}
