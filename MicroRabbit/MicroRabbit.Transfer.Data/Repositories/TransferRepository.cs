using MicroRabbit.Transfer.Data.Contexts;
using MicroRabbit.Transfer.Domain.Interfaces;
using MicroRabbit.Transfer.Domain.Models;
using System.Collections.Generic;

namespace MicroRabbit.Transfer.Data.Repositories
{
    public class TransferRepository : ITransferRepository
    {
        private readonly TransferDbContext _context;
        public TransferRepository(TransferDbContext context)
        {
            _context = context;
        }

        public void Add(TransferLog transferLog)
        {
            _context.TransferLogs.Add(transferLog);
            _context.SaveChanges();
        }

        public IEnumerable<TransferLog> GetTransfers()
        {
            return _context.TransferLogs;
        }
    }
}
