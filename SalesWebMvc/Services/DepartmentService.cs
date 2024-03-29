﻿using SalesWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SalesWebMvc.Services
{
    public class DepartmentService
    {
        public readonly SalesWebMvcContext _context;

        public DepartmentService(SalesWebMvcContext context)
        {
            _context = context;
        }

        /*public async Task<List<Department>> FindAll()
        {
            return _context.Department.OrderBy(d => d.Name).ToList();
        }*/

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(d => d.Name).ToListAsync();
        }
    }
}
