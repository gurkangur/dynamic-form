using System;
using System.Collections.Generic;
using System.Text;

namespace DynamicForm.Entities
{
    public class FormGroup
    {
        public int Id { get; set; }
        public int FormId { get; set; }
        public string Name { get; set; }
        public int Index { get; set; }
    }
}
