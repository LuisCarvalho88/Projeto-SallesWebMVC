using SallesWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SallesWebMvc.Services
{
    public class DepartmentService
    {
        private readonly SalesWebMvcContext _context;

        public DepartmentService(SalesWebMvcContext context)
        {
            _context = context;
        }

        //operação sincrona
        //public List<Department> FindAll()
        //{
        //    return _context.Department.OrderBy(x => x.Name).ToList();
        //}

        //operação asincrona
        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
