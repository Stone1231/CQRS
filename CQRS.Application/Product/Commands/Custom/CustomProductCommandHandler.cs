using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CQRS
{
    public class CustomProductCommandHandler : AsyncRequestHandler<CustomProductCommand>
    {
        private readonly IMediator _mediator;

        public CustomProductCommandHandler(IMediator mediator)
        {
            _mediator = mediator;
        }

        protected override Task Handle(CustomProductCommand command, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}
