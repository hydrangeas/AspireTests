var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.AspireTests_API>("aspiretests.api");

builder.AddProject<Projects.AspireTests_Web>("aspiretests.web");

builder.Build().Run();
