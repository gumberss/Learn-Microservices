using MicroRabbit.Transfer.Data.Context;
using MicroRabbit.Transfer.Domain.Interfaces;
using MicroRabbit.Transfer.Domain.Models;
using System.Collections.Generic;

namespace MicroRabbit.Transfer.Data.Repository
{
    public class TransferRepository :  ITransferRepository
    {
        private TransferDbContext _ctx;

        public IEnumerable<TransferLog> GetTransferLogs()
        {
            return _ctx.TranferLogs;
        }

    }
}
