using System;
using ub.bo;
using ub.bl;
using ub.da;
namespace ub.pl
{
    public partial class CustomerRegistration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Save_Click(object sender, EventArgs e)
        {
            var acc = new Account();

            acc.CustomerNumber = Convert.ToInt32(txt_customernumber.Text);
            acc.AccountName = txt_accountname.Text;
            acc.AccountAlias = txt_accountalias.Text;
            acc.AccountNumber = ddl_bankname.SelectedItem.Value + ddl_branchname.SelectedItem.Value +
                                Convert.ToInt32(txt_accountnumber.Text) + ddl_suffix.SelectedItem.Value;
           acc.Date = DateTime.Now.ToShortDateString();
            acc.AccountBalance = Convert.ToInt32(txt_accountbalance.Text);
            acc.AccountStatus = rdbtnl_accountstatus.SelectedItem.ToString();
            acc.AccountType = ddl_suffix.SelectedItem.ToString();

        
            StoringinAccountBl.SaveCustomer(acc);
            
           
        }
    }
}