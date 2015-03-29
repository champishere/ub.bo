namespace ub.bo
{
   public  class Transaction:Account
    {
       public string TransactionValue { get; set; }

       public string CreditedTo { get; set; }

       public string DebitedFrom { get; set; }

       public string Particulars { get; set; }

       public string Code { get; set; }

       public string Reference { get; set; }
    }
}
