using ub.bo;
using ub.da;
namespace ub.bl
{
  public  class StoringinAccountBl
    {
        public static void SaveCustomer(Account acc)
        {
            StoreAccount.AddAccount(acc);
        }
    }
}
