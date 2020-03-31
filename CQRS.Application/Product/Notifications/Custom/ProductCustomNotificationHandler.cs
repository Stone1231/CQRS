using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CQRS
{
    public class ProductCustomNotificationHandler : INotificationHandler<ProductDeletedNotification>
    {
        public Task Handle(ProductDeletedNotification notification, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}
