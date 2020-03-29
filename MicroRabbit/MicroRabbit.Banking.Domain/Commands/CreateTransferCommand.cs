using MicroRabbit.Domain.Core.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Banking.Domain.Commands
{
    public  class CreateTransferCommand: TransferCommand
    {
        private object p;

        public CreateTransferCommand(object p)
        {
            this.p = p;
        }

        public CreateTransferCommand(int from, int to, decimal  amount)
        {
            From = from;
            To = to;
            Amount = amount;
        }
    }
}