using DynamicForm.Enums;
using System.Collections;
using System.Collections.Generic;

namespace DynamicForm.Entities
{
    public class FormField
    {
        public int Id { get; set; }
        public int FormGroupId { get; set; }
        public FormGroup FormGroup { get; set; }
        public FieldType FieldType { get; set; }
        public string Name { get; set; }
        public int Index { get; set; }
        public bool IsOptional { get; set; }
        public bool IsActive { get; set; }
        public virtual ICollection<OptionFormField> OptionFormFields { get; set; }
        public virtual ICollection<FilledFormField> FilledFormFields { get; set; }
    }
}
