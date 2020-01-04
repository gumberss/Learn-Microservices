using System;

namespace MicroRabbit.Banking.Domain.Models
{
    public class Account
    {
        public int Id { get; set; }

        public String Type { get; set; }

        public decimal Balance { get; set; }

    }
}
