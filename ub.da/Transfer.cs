using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using ub.bo;

namespace ub.da
{
    public static class Transfer
    {
        public static int check;
        public static void ValidateCustomer(Account acc)
        {
            using (
                var con =
                    new SqlConnection(
                        ConfigurationManager.ConnectionStrings["BankConnectionString"].ConnectionString)
                )
            {

                using (var cmd =
                    new SqlCommand("StoredProcedureValidateCustomer",
                        con))

                {
                    con.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@CustomerNumber", acc.CustomerNumber);
                    cmd.Parameters.AddWithValue("@AccountName", acc.AccountName);
                    var da = new SqlDataAdapter(cmd);
                    var dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        check = (int) cmd.ExecuteScalar();
                    }
                    con.Close();
                }
            }
        }
    }
}