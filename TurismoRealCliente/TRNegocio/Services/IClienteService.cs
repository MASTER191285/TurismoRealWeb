using TRNegocio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRNegocio.Services
{
    public interface IClienteService
    {
        ClienteDto GetClienteByCredentials(ClienteDto p_filtro);

        BaseDto<ClienteDto> GetClienteByMail(ClienteDto p_filtro);
       
    }
}
