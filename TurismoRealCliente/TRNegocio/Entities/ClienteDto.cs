using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRNegocio.Entities
{
    [Serializable]
    public class ClienteDto : ObjectDto
    {
        #region Constructores
        public ClienteDto() : base() { }
        public ClienteDto(int PaginaActual, int TamanoPagina) : base(PaginaActual, TamanoPagina) { }
        #endregion

        #region PropiedadesPublicas
        public int cl_id { get; set; }
        public string cl_rut { get; set; }
        public string cl_nombre { get; set; }
        public string cl_apellidop { get; set; }
        public string cl_apellidom { get; set; }
        public DateTime cl_fechanac { get; set; }
        public string cl_email { get; set; }
        public int cl_fono { get; set; }
        public DateTime cl_fecha_registro { get; set; }
        public string cl_clave { get; set; }
        public string cl_estado { get; set; }
        public int cl_multas { get; set; }
        public int cl_reserva { get; set; }
        #endregion
    }
}
