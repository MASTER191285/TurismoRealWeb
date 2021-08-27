using TRNegocio.Entities;
using TRNegocio.Services;
using AppTurismoReal.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppTurismoReal.Web.Controllers
{
    public class AccountController : Controller
    {
        #region Propiedades Privadas
        private IClienteService ClienteServiceModel
        {
            get { return ClienteService.GetInstance(); }
        }

        public int Property
        {
            get => default(int);
            set
            {
            }
        }
        #endregion

        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

        // GET: Account/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Account/Create
        public ActionResult Create()
        {
            return View();
        }

        
        [AllowAnonymous]
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(AccountViewModel p_ViewModel)
        {
            try
            {
                TempData.Clear();
                if (ModelState.IsValid)
                {
                    ClienteDto clienteInfo = new ClienteDto
                    {
                        cl_email = p_ViewModel.CL_Email,
                        cl_clave = p_ViewModel.CL_Clave
                    };

                    if (!string.IsNullOrEmpty(clienteInfo.cl_email) || !string.IsNullOrEmpty(clienteInfo.cl_clave))
                    {
                        var clienteFilterObj = new ClienteDto();
                        clienteFilterObj.cl_email = p_ViewModel.CL_Email;
                        clienteFilterObj.cl_clave = p_ViewModel.CL_Clave;

                        var clienteDB = ClienteServiceModel.GetClienteByCredentials(clienteFilterObj);
                    }
                }

            }
            catch (Exception ex)
            {

                throw new Exception("Error al ingresar", ex);
            }

            return View(p_ViewModel);

        }

        // POST: Account/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Account/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Account/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Account/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Account/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
