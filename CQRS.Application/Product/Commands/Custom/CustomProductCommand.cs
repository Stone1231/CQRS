using MediatR;

namespace CQRS
{
    public class CustomProductCommand : IRequest
    {
        public long Id { get; set; }
    }
}
