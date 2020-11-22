using MediatR;
using MicroRabbit.Banking.Domain.CommandHandlers;
using MicroRabbit.Banking.Domain.Commands;
using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Infra.Bus;
using MicroRabbit.Transfer.Domain.EventHndlers;
using MicroRabbit.Transfer.Domain.Events;
using Microsoft.Extensions.DependencyInjection;


namespace MicroRabbit.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection  services)
        {
            // Domain Bus register 
            services.AddSingleton<IEventBus, RabbitMQBus>(sp => 
            {
                var scopeFactory = sp.GetRequiredService<IServiceScopeFactory>();
                return new RabbitMQBus(sp.GetService<IMediator>(), scopeFactory);
            });

          
           

            //Domain Banking Command
            services.AddTransient<IRequestHandler<CreateTransferCommand, bool>, TransferCommandHandler>();
        }
    }
}
