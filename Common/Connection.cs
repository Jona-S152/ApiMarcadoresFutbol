using Microsoft.Extensions.Configuration;

namespace ApiMarcadoresFutbol.Common
{
    public class Connection
    {

        //public readonly IConfiguration _configuration;

        public static string ConnectionString = "Server=DESKTOP-ACPBVCU\\SQLEXPRESS;Database=DB_Marcadores;Trusted_Connection=True;TrustServerCertificate=True;";
        //public static void Initialize(IConfiguration configuration)
        //{
        //    ConnectionString = configuration.GetConnectionString("DB_Marcadores");
        //}
    }
}
