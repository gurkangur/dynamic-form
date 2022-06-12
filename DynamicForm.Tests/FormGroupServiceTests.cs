using DynamicForm.Services;
using DynamicForm.Tests.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DynamicForm.Tests
{
    public class FormGroupServiceTests:CommandTestBase
    {
        [Fact]
        public async Task Add()
        {
            var formGroup = new Entities.FormGroup
            {
                FormId = 1,
                Index = 1,
                Name = "Form Group 1"
            };
            var formGroupService = new FormGroupService(_context);
            await formGroupService.Add(formGroup);

            var form = _context.FormGroups.FirstOrDefault(t => t.Name == formGroup.Name && t.FormId == formGroup.FormId);
            Assert.NotNull(form);
        }
    }
}
