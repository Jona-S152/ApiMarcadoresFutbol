using ApiMarcadoresFutbol.Entities;
using System.Net.NetworkInformation;
using System.Reflection;

namespace ApiMarcadoresFutbol.Common
{
    public class QuerysMarcadores
    {
        public static string GetAllMarcadores()
        {
            return "SELECT * FROM Marcadores";
        }

        //public static string InsertMarcadores(Marcadores marcadores)
        //{
        //    return $"INSERT INTO Marcadores (IdPartido, EtapaLiga, EquipoLocal, EquipoVisitante, FechaPartido, Resultado) " +
        //        $"VALUES ('{marcadores.IdPartido}', '{marcadores.EtapaLiga}', '{marcadores.EquipoLocal}', '{marcadores.EquipoVisitante}', '{marcadores.FechaPartido}', '{marcadores.Resultado}')";
        //}
    }
}
