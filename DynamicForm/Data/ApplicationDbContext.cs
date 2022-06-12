using DynamicForm.Entities;
using Microsoft.EntityFrameworkCore;

namespace DynamicForm.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<FilledForm> FilledForms { get; set; }
        public DbSet<FilledFormField> FilledFormFields { get; set; }
        public DbSet<Form> Forms { get; set; }
        public DbSet<FormField> FormFields { get; set; }
        public DbSet<FormGroup> FormGroups { get; set; }
        public DbSet<Option> Options { get; set; }
        public DbSet<OptionFormField> OptionFormFields { get; set; }
    }
}
