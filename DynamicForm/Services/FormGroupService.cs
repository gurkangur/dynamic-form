using DynamicForm.Data;
using DynamicForm.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DynamicForm.Services
{
    public class FormGroupService
    {
        private readonly ApplicationDbContext _context;

        public FormGroupService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task Add(FormGroup formGroup)
        {
            _context.FormGroups.Add(formGroup);
            await _context.SaveChangesAsync();
        }
    }
}
