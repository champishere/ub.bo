namespace ub.bo
{
   public class ChequeAccount:Account
    {
        public double OverDraft { get; set; } 
        public override double AccountBalance { get; set; }
    }
   
}
