using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Login.Areas.Admin.Data
{
    public class LoginModel
    {
        [Required]

        public string UserName { get; set; }
        public string PassWord { get; set; }
    }
}