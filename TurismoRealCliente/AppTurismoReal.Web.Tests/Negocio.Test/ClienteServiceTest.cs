using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRNegocio.DAL;
using TRNegocio.Entities;
using TRNegocio.Services;
using Moq;

namespace AppTurismoReal.Web.Tests.Negocio.Test
{
    [TestClass]
    public class ClienteServiceTest
    {
        Mock<IClienteService> mockClienteService;

        #region Setup
        [TestInitialize]
        public void Setup()
        {
            //mockClienteService = new Mock<IClienteService>(MockBehavior, default);
            mockClienteService = new Mock<IClienteService>();
            GetClientesTest();

        }
        #endregion

        [TestMethod]
        public void GetClientesTest()
        { 
            var filtroObj = new ClienteDto { cl_email = "yuri_lopez@vtr.net", cl_clave = "191285" };
            IClienteService service = mockClienteService.Object;
            var serviceResponse = service.GetClienteByCredentials(filtroObj);

            //Assert.IsFalse(serviceResponse.valu);
        
        }
    }
}
