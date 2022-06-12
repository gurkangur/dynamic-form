using System.Collections.Generic;

namespace DynamicForm.Entities
{
    public class Option
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }

        public virtual ICollection<OptionFormField> OptionFormFields { get; set; }
        public virtual ICollection<FilledFormField> FilledFormFields { get; set; }
    }
}
