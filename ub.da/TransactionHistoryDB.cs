using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using ub.bo;

namespace ub.da
{
    public class TransactionHistoryDB
    {
        public static void AddHistory(Transaction ts)
        {//@TransactionValue, @TransactionDate, @CreditedTo, @DebitedFrom, @particulars, @Code, @Reference
            using (
                    var con =
                        new SqlConnection(
                            ConfigurationManager.ConnectionStrings["BankConnectionString"].ConnectionString)
                    )
            {

                using (var cmd =
                    new SqlCommand("StoredProcedureTransactionHistory",
                        con))
                {

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@CustomerNumber", ts.CustomerNumber);
                    cmd.Parameters.AddWithValue("@TransactionValue", ts.TransactionValue);
                    cmd.Parameters.AddWithValue("@TransactionDate", ts.Date);
                    cmd.Parameters.AddWithValue("@CreditedTo", ts.CreditedTo);
                    cmd.Parameters.AddWithValue("@DebitedFrom", ts.DebitedFrom);
                    cmd.Parameters.AddWithValue("@particulars", ts.Particulars);
                    cmd.Parameters.AddWithValue("@Code", ts.Code);
                    cmd.Parameters.AddWithValue("@Reference", ts.Reference);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }

        }
    }
}
