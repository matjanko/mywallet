using MyWallet.Debts;
using MyWallet.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddInfrastructure();
builder.Services.AddDebts();

var app = builder.Build();
app.UseInfrastructure();

app.Run();