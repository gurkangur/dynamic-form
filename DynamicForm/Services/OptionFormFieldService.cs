using DynamicForm.Data;
using DynamicForm.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DynamicForm.Services
{
    public class OptionFormFieldService
    {
        private readonly ApplicationDbContext _context;

        public OptionFormFieldService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Add(OptionFormField optionFormField)
        {
            _context.OptionFormFields.Add(optionFormField);
            await _context.SaveChangesAsync();
        }
    }
}
