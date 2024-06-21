using ApiMarcadoresFutbol.Common;
using ApiMarcadoresFutbol.Entities;
using System.Data;
using System.Data.SqlClient;

namespace ApiMarcadoresFutbol.DAL
{
    public class MarcadoresLiga
    {

        public static DataSet GetAllMarcadores()
        {
            SqlConnection conn = new SqlConnection(Connection.ConnectionString);

            DataSet ds = new DataSet();
            try
            {
                SqlCommand com = new SqlCommand(QuerysMarcadores.GetAllMarcadores(), conn);
                com.CommandType = CommandType.Text;

                conn.Open();
                com.ExecuteNonQuery();
                SqlDataAdapter adapter = new SqlDataAdapter(com);
                adapter.Fill(ds);
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
            return ds;
        }

        public static void InsertMarcadores(MarcadoresParametros MParametros)
        {
            Marcadores marcadores = new Marcadores();
            marcadores.IdPartido = string.Empty;
            marcadores.EtapaLiga = MParametros.Etapa;
            marcadores.EquipoLocal = MParametros.ELocal;
            marcadores.EquipoVisitante = MParametros.EVisitante;
            marcadores.FechaPartido = MParametros.Fecha;
            marcadores.Resultado = MParametros.Resultado;

            Execute_Sp_MarcadoresLiga("I", marcadores);
        }

        public static void DeleteMarcadores(string id, MarcadoresParametros MParametros)
        {
            Marcadores marcadores = new Marcadores();
            marcadores.IdPartido = id;
            marcadores.EtapaLiga = string.Empty;
            marcadores.EquipoLocal = string.Empty;
            marcadores.EquipoVisitante = string.Empty;
            marcadores.FechaPartido = string.Empty;
            marcadores.Resultado = string.Empty;

            Execute_Sp_MarcadoresLiga("D", marcadores);
        }

        private static void Execute_Sp_MarcadoresLiga(string opcion, Marcadores marcadores)
        {
            SqlConnection conn = new SqlConnection(Connection.ConnectionString);

            try
            {
                SqlCommand com = new SqlCommand(SpNames.sp_MarcadoresLiga, conn);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@Opcion", opcion);
                com.Parameters.AddWithValue("@Codigo", marcadores.IdPartido);
                com.Parameters.AddWithValue("@Etapa", marcadores.EtapaLiga);
                com.Parameters.AddWithValue("@ELocal", marcadores.EquipoLocal);
                com.Parameters.AddWithValue("@EVisitante", marcadores.EquipoVisitante);
                com.Parameters.AddWithValue("@Fecha", marcadores.FechaPartido);
                com.Parameters.AddWithValue("@Resultado", marcadores.Resultado);

                conn.Open();
                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
