using Xunit;
using Grpc.Core;
using GrpcSuccessService.Services; // Namespace of your service implementation
using Google.Protobuf.WellKnownTypes; // For Empty
using System.Threading.Tasks;

namespace GrpcSuccessService.Tests
{
    public class SuccessServiceTests
    {
        [Fact]
        public async Task GetSuccess_ReturnsSuccessMessage()
        {
            // Arrange
            var service = new SuccessServiceImpl();
            var context = new ServerCallContext(null, null, null, null, null, null, null); // Basic mock context

            // Act
            var response = await service.GetSuccess(new Empty(), context);

            // Assert
            Assert.NotNull(response);
            Assert.Equal("Success", response.Message);
        }
    }
}
