using TRNegocio.Entities;
using TRNegocio.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRNegocio.Services
{
    public class ClienteService : IClienteService
    {
        #region Propiedades Privadas
        private static ClienteService Instance = null;
        private TRNegocio.DAL.TurismoRealEntities dbContext = null;
        #endregion

        #region Singleton
        private ClienteService() { }
        public static ClienteService GetInstance()
        {
            if (ClienteService.Instance == null)
                ClienteService.Instance = new ClienteService();
            
            return ClienteService.Instance;
        }
        #endregion

        #region Metodos Publicos
        public ClienteDto GetClienteByCredentials(ClienteDto p_filtro)
        {
            ClienteDto objResult = null;
            try
            {
                using (this.dbContext = new TurismoRealEntities())
                {
                    var clienteDB = (from u in this.dbContext.CLIENTE
                                     where u.CL_EMAIL == p_filtro.cl_email &&
                                           u.CL_CLAVE == p_filtro.cl_clave &&
                                           u.CL_ESTADO.Equals("1")
                                     select u).FirstOrDefault();
                    
                    if (clienteDB != null)
                    {
                        objResult = new ClienteDto
                        {
                            cl_id = Convert.ToInt32(clienteDB.CL_ID),
                            cl_nombre = clienteDB.CL_NOMBRE,
                            cl_apellidop = clienteDB.CL_APELLIDOP,
                            cl_apellidom = clienteDB.CL_APELLIDOM,
                            cl_fechanac = clienteDB.CL_FECHANAC,
                            cl_email = clienteDB.CL_EMAIL,
                            cl_fono = Convert.ToInt32(clienteDB.CL_FONO),
                            cl_fecha_registro = clienteDB.CL_FECHA_REGISTRO,
                            cl_estado = clienteDB.CL_ESTADO,
                            cl_multas = Convert.ToInt32(clienteDB.CL_MULTAS),
                            cl_reserva = clienteDB.CL_RESERVA


                        };
                    }
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Error al obtener el objeto en la busqueda ", ex);
            }

            return objResult;
        }

        public BaseDto<ClienteDto> GetClienteByMail(ClienteDto p_filtro)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
