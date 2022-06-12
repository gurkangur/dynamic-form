using DynamicForm.Data;
using DynamicForm.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DynamicForm.Tests.Common
{
    public class ApplicationDbContextFactory
    {
        public static ApplicationDbContext Create()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;

            var context = new ApplicationDbContext(options);

            context.Database.EnsureCreated();



            context.Forms.Add(new Form
            {
                Id = 1,
                Description = "User Form",
                CreationDate = DateTime.Now
            });
            context.FormGroups.Add(new FormGroup
            {
                Id = 1,
                Index = 0,
                FormId = 1,
                Name = "User Form Group 1"
            });
            context.FormFields.AddRange(new[] {
                 new FormField
                {
                    FieldType = Enums.FieldType.Textbox,
                    FormGroupId = 1,
                    IsOptional = false,
                    Index = 0,
                    Name = "Name"
                },
                     new FormField
                {
                    FieldType = Enums.FieldType.Textbox,
                    FormGroupId = 1,
                    IsOptional = false,
                    Index = 1,
                    Name = "Surname"
                }
            });
            context.SaveChanges();

            return context;
        }

        public static void Destroy(ApplicationDbContext context)
        {
            context.Database.EnsureDeleted();

            context.Dispose();
        }
    }
}
