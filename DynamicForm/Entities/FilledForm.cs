using System;
using System.Collections.Generic;
using System.Text;

namespace DynamicForm.Entities
{
    public class FilledForm
    {
        public int Id { get; set; }
        public int FormId { get; set; }
        public DateTime FillDate { get; set; }
    }
}
