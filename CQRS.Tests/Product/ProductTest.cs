using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CQRS
{
    [TestClass]
    public class ProductTest
    {
        private readonly IMediator _mediator;

        public ProductTest()
        {
            var services = new ServiceCollection();

            services.AddMediatR(typeof(InsertProductCommand));

            _mediator = services.BuildServiceProvider().GetService<IMediator>();
        }

        [TestMethod]
        public async Task Custom()
        {
            var command = new CustomProductCommand { Id = 1 };
            //CustomProductCommandHandler使用DeleteProductCommand, DeleteProductCommandHandler會接收不到
            await _mediator.Send(command);
        }

        [TestMethod]
        public async Task Delete()
        {
            var command = new DeleteProductCommand { Id = 1 };

            await _mediator.Send(command);//除了Delete, Custom也會
        }

        [TestMethod]
        public async Task GetById()
        {
            var query = new GetByIdProductQuery { Id = 1 };

            var result = await _mediator.Send(query);
        }

        [TestMethod]
        public async Task Insert()
        {
            var command = new InsertProductCommand { Description = "Description" };

            await _mediator.Send(command);
        }

        [TestMethod]
        public async Task Update()
        {
            var command = new UpdateProductCommand { Id = 1, Description = "Description" }; ;

            await _mediator.Send(command);
        }
    }
}
