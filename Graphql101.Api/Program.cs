var builder = WebApplication.CreateBuilder(args);

builder
    .Services.AddGraphQLServer()
    .AddQueryType<Query>()
    .AddType<Cat>()
    .AddType<Dog>()
    .AddType<Parrot>()
    .ModifyOptions(options => options.StripLeadingIFromInterface = true);

var app = builder.Build();

if (app.Environment.IsDevelopment()) { }

app.UseHttpsRedirection();

app.MapGraphQL();

app.Run();
