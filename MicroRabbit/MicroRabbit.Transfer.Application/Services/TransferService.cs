using MicroRabbit.Transfer.Application.Interfaces;
using MicroRabbit.Transfer.Application.Models;
using MicroRabbit.Transfer.Domain.Interfaces;
using MicroRabbit.Transfer.Domain.Models;
using System;
using System.Collections.Generic;
using MicroRabbit.Domain.Core.Bus;

namespace MicroRabbit.Transfer.Application.Services
{
    public class TransferService : ITransferService
    {
        private readonly ITransferRepository _repository;
        private readonly IEventBus _bus;
        public TransferService(ITransferRepository repository, IEventBus bus)
        {
            _repository = repository;
            _bus = bus;
        }

        // Make sure you return viewmodel here instead all the conrete class

        public IEnumerable<TransferLog> GetTransfer()
        {
            return _repository.GetTransfers();
        }
    }
}
