using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using ub.bo;

namespace ub.da
{
    public class StoreAccount
    {
        public static void AddAccount(Account acc)
        {
            
            
                using (
                    var con =
                        new SqlConnection(
                            ConfigurationManager.ConnectionStrings["BankConnectionString"].ConnectionString)
                    )
                {

                    using (var cmd =
                        new SqlCommand("StoredProcedureAccount",
                            con))
                    {

                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@CustomerNumber", acc.CustomerNumber);
                        cmd.Parameters.AddWithValue("@AccountName", acc.AccountName);
                        cmd.Parameters.AddWithValue("@AccountAlias", acc.AccountAlias);
                        cmd.Parameters.AddWithValue("@AccountNumber", acc.AccountNumber);
                        cmd.Parameters.AddWithValue("@Date", acc.Date);
                        cmd.Parameters.AddWithValue("@AccountBalance", acc.AccountBalance);
                        cmd.Parameters.AddWithValue("@AccountStatus", acc.AccountStatus);
                        cmd.Parameters.AddWithValue("@AccountType", acc.AccountType);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }

            }
        }
    }

