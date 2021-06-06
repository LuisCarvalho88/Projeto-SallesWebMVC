using Microsoft.AspNetCore.Mvc;
using SallesWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using SallesWebMvc.Models.ViewModels;

namespace SallesWebMvc.Models.ViewModels
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }
        public string Message { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}