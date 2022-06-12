using DynamicForm.Enums;

namespace DynamicForm.Entities
{
    public class FormField
    {
        public int Id { get; set; }
        public int FormGroupId { get; set; }
        public FieldType FieldType { get; set; }
        public string Name { get; set; }
        public int Index { get; set; }
        public bool IsOptional { get; set; }
        public bool IsActive { get; set; }
    }
}
