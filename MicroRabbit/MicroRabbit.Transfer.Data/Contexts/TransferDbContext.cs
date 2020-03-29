using MicroRabbit.Transfer.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Transfer.Data.Contexts
{
    public class TransferDbContext: DbContext
    {
        public TransferDbContext(DbContextOptions<TransferDbContext> options): base(options)
        { }

        public DbSet<TransferLog> TransferLogs { get; set; }
    }
}
