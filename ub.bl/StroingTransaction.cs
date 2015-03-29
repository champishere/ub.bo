using ub.bo;
using ub.da;

namespace ub.bl
{
    public class StroingTransaction
    {
        public static void SaveTransaction(Transaction ts)
        {
            TransactionHistoryDB.AddHistory(ts);
            
        }
    }
}
