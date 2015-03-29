using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using ub.bl;
using ub.bo;

namespace ub.pl
{
    public partial class TransferWithinAccounts : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void btn_submit_Click(object sender, EventArgs e)
        {
            if(ddl_from.SelectedItem.ToString() == ddl_to.SelectedItem.ToString())
            {
                Response.Write("<script>alert('Can not transfer amount');</Script>");
            }
            else if (Convert.ToDouble(txt_amount.Text) > 1000)
            {
                 Response.Write("<script>alert('Can not transfer ');</Script>");
            }
            else
            {
            int balancedebit = 0;
            int balancewithdrawl = 0;
            var con =
                new SqlConnection(
                    ConfigurationManager.ConnectionStrings["BankConnectionString"].ConnectionString);



            var cmd =
                new SqlCommand("Select AccountBalance From Account Where CustomerNumber=@Cn and AccountType=@at", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Cn", Session["CustomerNumber"]);
            cmd.Parameters.AddWithValue("@at", ddl_from.SelectedItem.ToString());
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                
                balancedebit = (Convert.ToInt32(dr["AccountBalance"].ToString()) - Convert.ToInt32(txt_amount.Text));
                
                //Response.Write("session" + balancedebit);
            }
            dr.Close();
            if (balancedebit < -1000)
            {
                Response.Write("<script>alert('Can not transfer ');</Script>");
            }
            else
            {

                var cmdm =
                    new SqlCommand("Update Account set AccountBalance=" + balancedebit + "Where CustomerNumber=@Cn and AccountType=@at", con);
                cmdm.Parameters.AddWithValue("@Cn", Session["CustomerNumber"]);
                cmdm.Parameters.AddWithValue("@at", ddl_from.SelectedItem.ToString());

                cmdm.ExecuteNonQuery();

                Response.Write("session");


                var cmdd =
                    new SqlCommand("Select AccountBalance From Account Where CustomerNumber=@Cn and AccountType=@at", con);
                cmdd.CommandType = CommandType.Text;
                cmdd.Parameters.AddWithValue("@Cn", Session["CustomerNumber"]);
                cmdd.Parameters.AddWithValue("@at", ddl_to.SelectedItem.ToString());

                SqlDataReader drr = cmdd.ExecuteReader();
                while (drr.Read())
                {
                    balancewithdrawl = (Convert.ToInt32(drr["AccountBalance"].ToString()) + Convert.ToInt32(txt_amount.Text));
                    //Response.Write("session" + balancedebit);
                }
                drr.Close();
                var cmdmm =
                    new SqlCommand("Update Account set AccountBalance=" + balancewithdrawl + "Where CustomerNumber=@Cn and AccountType=@at", con);
                cmdmm.Parameters.AddWithValue("@Cn", Session["CustomerNumber"]);
                cmdmm.Parameters.AddWithValue("@at", ddl_to.SelectedItem.ToString());

                cmdmm.ExecuteNonQuery();

                // Response.Write("session");

                var ts = new Transaction();

                ts.CustomerNumber = (int)Session["CustomerNumber"];
                ts.TransactionValue = txt_amount.Text;
                ts.Date = DateTime.Now.ToShortDateString();
                ts.CreditedTo = ddl_to.SelectedItem.ToString();
                ts.DebitedFrom = ddl_from.SelectedItem.ToString();
                ts.Particulars = txt_particulars.Text;
                ts.Code = txt_code.Text;
                ts.Reference = txt_reference.Text;

                StroingTransaction.SaveTransaction(ts);
                
                if (ddl_from.SelectedItem.ToString()=="Savings")
                {

                    if (balancedebit < 0)
            {
                        var cmdmmm =
                    new SqlCommand("Update Account set AccountBalance=" + balancedebit*2 + "Where CustomerNumber=@Cn and AccountType=@at", con);
                cmdmmm.Parameters.AddWithValue("@Cn", Session["CustomerNumber"]);
                cmdmmm.Parameters.AddWithValue("@at", ddl_from.SelectedItem.ToString());
                        cmdmmm.ExecuteNonQuery();
                        
                }
                }
                con.Close();
            }
            }
        }

    }
}