var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.Semefo_ApiService>("apiservice");

builder.AddProject<Projects.Semefo_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService);

builder.Build().Run();
