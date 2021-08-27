using TRNegocio.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AppTurismoReal.Web.Models
{
    public class AccountViewModel
    {
        [Required(ErrorMessage = "Debe ingresar el Mail")]
        [Display(Name = "Mail Otorgado")]
        public string CL_Email
        {
            get;
            set;
        }

        [Required(ErrorMessage = "Debe ingresar la contraseña")]
        [Display(Name = "Contraseña")]
        public string CL_Clave
        {
            get;
            set;
        }
    }
}