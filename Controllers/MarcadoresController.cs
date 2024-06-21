using ApiMarcadoresFutbol.DAL;
using ApiMarcadoresFutbol.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace ApiMarcadoresFutbol.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarcadoresController : ControllerBase
    {
        [HttpGet]
        public List<Marcadores> GetMarcadores()
        {
            DataSet ds = MarcadoresLiga.GetAllMarcadores();

            List<Marcadores> list = new List<Marcadores>();
            if (ds != null && ds.Tables.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    list.Add(new Marcadores
                    {
                        IdPartido = dr["IdPartido"].ToString(),
                        EtapaLiga = dr["EtapaLiga"].ToString(),
                        EquipoLocal = dr["EquipoLocal"].ToString(),
                        EquipoVisitante = dr["EquipoVisitante"].ToString(),
                        FechaPartido = dr["FechaPartido"].ToString(),
                        Resultado = dr["Resultado"].ToString()
                    });
                }
            }
            return list;
        }

        [HttpPost]
        public void InsertMarcadores([FromBody] MarcadoresParametros MParametros)
        {
            MarcadoresLiga.InsertMarcadores(MParametros);
        }

        [HttpDelete("{id}")]
        public void DeleteMarcadores(string id)
        {
            MarcadoresLiga.DeleteMarcadores(id, new MarcadoresParametros());
        }
    }
}
