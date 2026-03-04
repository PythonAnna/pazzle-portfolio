var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.PracticeAPI>("practiceapi");

builder.Build().Run();
