using System;

namespace ChequeMaintanance.Models
{
    public class VmAddCheque
    {
        public string Mode { get; set; }
        public decimal ChequeDetailsId { get; set; }
        public string ChequeNumber { get; set; }
        public string GivenTo { get; set; }
        public string GivenDate { get; set; }
        public string ValidUpto { get; set; } 
        
        public decimal Amount { get; set; }
        public string Notes { get; set; }
        public bool IsDeleted { get; set; }
    }
}