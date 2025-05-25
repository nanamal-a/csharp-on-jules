using Grpc.Core;
using GrpcSuccessService; // This is the namespace from the .proto file's csharp_namespace option
using Google.Protobuf.WellKnownTypes; // Required for Empty

namespace GrpcSuccessService.Services
{
    public class SuccessServiceImpl : SuccessService.SuccessServiceBase
    {
        public override Task<SuccessResponse> GetSuccess(Empty request, ServerCallContext context)
        {
            return Task.FromResult(new SuccessResponse
            {
                Message = "Success"
            });
        }
    }
}
