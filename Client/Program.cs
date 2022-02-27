
while (true)
{
    Console.WriteLine("Enter Id");
    int Id = Convert.ToInt32(Console.ReadLine());

    using (var channel = Grpc.Net.Client.GrpcChannel.ForAddress("https://localhost:5178/"))
    {
        var client = new WebApiServer.DemoProtos.DemoService.DemoServiceClient(channel);
        var request = new WebApiServer.DemoProtos.DemoRequest { Id = Id };
        var result = client.GetDemoData(request);
        Console.WriteLine(result.Id);
        Console.WriteLine(result.Name);
        Console.WriteLine("-----");
    }
}

