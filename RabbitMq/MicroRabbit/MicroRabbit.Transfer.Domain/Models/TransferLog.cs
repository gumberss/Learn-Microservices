﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Transfer.Domain.Models
{
    public class TransferLog
    {

        public int Id { get; set; }

        public int FromAccount { get; set; }

        public int toAccount { get; set; }

        public decimal TrsnferAmount { get; set; }
    }
}
