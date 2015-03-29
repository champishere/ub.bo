using System;
using ub.bo;
using ub.bl;
using ub.da;

namespace ub.pl
{
    public partial class Trafers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_submit_Click(object sender, EventArgs e)
        {
           
            var acc = new Account();
            acc.CustomerNumber = Convert.ToInt32(txt_customernumber.Text);
            acc.AccountName = txt_accountname.Text;
            Transfer.ValidateCustomer(acc);
            if (Transfer.check >= 1)
            {
                Session["CustomerNumber"] = acc.CustomerNumber;
                Response.Write("" + Session["CustomerNumber"]);
                Response.Redirect("TransferWithinAccounts.aspx");
            }
            else
            {
                Response.Write("haad");
            }

        }
    }
}