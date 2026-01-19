var builder = DistributedApplication.CreateBuilder(args);

var postgres = builder.AddPostgres("postgres")
    .WithPgAdmin()
    .WithDataVolume();

var db = postgres.AddDatabase("vsadb");

var api = builder.AddProject<Projects.TWC_VSA_Api>("api")
        .WithReference(db);

builder.Build().Run();
