using DynamicForm.Services;
using DynamicForm.Tests.Common;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace DynamicForm.Tests
{
    public class FormFieldServiceTests : CommandTestBase
    {
        [Fact]
        public async Task Add_Select_Field()
        {
            var formField = new Entities.FormField
            {
                FieldType = Enums.FieldType.Select,
                FormGroupId = 1,
                IsOptional = false,
                Index = 2,
                Name = "Select 1",
                OptionFormFields = new[]{new Entities.OptionFormField {
                Index = 0,
                IsActive = true,
                Option = new Entities.Option
                {
                    Name = "222",
                    Value = "ww"
                }

                } }
            };
            var formFieldService = new FormFieldService(_context);
            await formFieldService.Add(formField);

            var form = _context.FormFields.FirstOrDefault(t => t.FieldType == formField.FieldType && t.FormGroupId == formField.FormGroupId && t.Name == formField.Name);

            Assert.NotNull(form);
        }


    }
}
