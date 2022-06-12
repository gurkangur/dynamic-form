using System.Collections.Generic;

namespace DynamicForm.Entities
{
    public class FormGroup
    {
        public int Id { get; set; }
        public int FormId { get; set; }
        public Form Form { get; set; }
        public string Name { get; set; }
        public int Index { get; set; }

        public virtual ICollection<FormField> FormFields { get; set; }

    }
}
