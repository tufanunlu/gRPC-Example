using Grpc.Core;
using WebApiServer.DemoProtos;

namespace WebApiServer.Services
{
    public class DemoService : WebApiServer.DemoProtos.DemoService.DemoServiceBase
    {
        public override Task<DemoResponse> GetDemoData(DemoRequest demoRequest, ServerCallContext context)
        {
            Dictionary<int, string> data = new Dictionary<int, string>() { { 1, "Adana" }, { 6, "Ankara" }, { 34, "İstanbul" }, { 41, "Kocaeli" }, { 58, "Sivas" }, { 59, "Tekirdağ" } };

            string name;
            data.TryGetValue(demoRequest.Id, out name);

            return Task.FromResult(new DemoResponse
            {
                Id = demoRequest.Id,
                Name = name
            });
        }
    }
}
