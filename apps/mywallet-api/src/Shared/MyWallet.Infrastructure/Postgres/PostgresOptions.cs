namespace MyWallet.Infrastructure.Postgres;

internal class PostgresOptions
{
    public const string Postgres = "Postgres";
    
    public string ConnectionString { get; set; } = string.Empty;
}
