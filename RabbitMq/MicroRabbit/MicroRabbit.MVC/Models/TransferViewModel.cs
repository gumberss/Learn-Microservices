using System;

namespace MicroRabbit.MVC.Models
{
    public class TransferViewModel
    {
        public String TransferNotes { get; set; }

        public int FromAccount { get; set; }

        public int ToAccount { get; set; }

        public decimal TransferAmount { get; set; }
    }
}
