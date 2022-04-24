using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EF_Code.Models;
using Microsoft.AspNetCore.Mvc;

namespace Controllers
{
    public class UyelerController : Controller
    {
        private readonly KutuphaneAksamContext _context;
        public UyelerController(KutuphaneAksamContext context)
        {
            _context=context;
        }
    }
}