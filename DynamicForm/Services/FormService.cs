using DynamicForm.Data;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace DynamicForm.Services
{
    public class FormService
    {
        private readonly ApplicationDbContext _context;

        public FormService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Add(string description)
        {
            _context.Forms.Add(new Entities.Form { Description = description, CreationDate = DateTime.Now });
            await _context.SaveChangesAsync();
        }

        public async Task Update(int id, string description)
        {
            var form = _context.Forms.FirstOrDefault(t => t.Id == id);
            if (form is null)
                throw new Exception();
            form.Description = description;
            _context.Forms.Update(form);
            await _context.SaveChangesAsync();
        }

    }
}
