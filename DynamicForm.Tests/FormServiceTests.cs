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
    public class FormServiceTests:CommandTestBase
    {
        [Fact]
        public async Task Add()
        {
            var description = "Form1";
            var formService = new FormService(_context);
            await formService.Add(description);

            var form = _context.Forms.FirstOrDefault(t => t.Description == description);
            Assert.Equal(description, form.Description);
        }
    }
}
