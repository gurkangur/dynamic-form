using System;
using System.Collections.Generic;
using System.Text;

namespace DynamicForm.Entities
{
    public class FilledForm
    {
        public int Id { get; set; }
        public int FormId { get; set; }
        public Form Form { get; set; }
        public DateTime FillDate { get; set; }

        public virtual ICollection<FilledFormField> FilledFormFields { get; set; }
    }
}
