using DynamicForm.Data;
using DynamicForm.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DynamicForm.Services
{
    public class FormFieldService
    {
        private readonly ApplicationDbContext _context;

        public FormFieldService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Add(FormField formField)
        {
            _context.FormFields.Add(formField);
            await _context.SaveChangesAsync();
        }
    }
}
