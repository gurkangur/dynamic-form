using System;

namespace DynamicForm.Entities
{
    public class FilledFormField
    {
        public int Id { get; set; }
        public int FilledFormId { get; set; }
        public int FormFieldId { get; set; }
        public bool IsChecked { get; set; }
        public string ColorPickerValue { get; set; }
        public int[] SelectedOptionIds { get; set; }
        public int SelectedOptionId { get; set; }
        public string TextValue { get; set; }
        public int IntValue { get; set; }
        public decimal DecimalValue { get; set; }
        public DateTime DateTimeValue { get; set; }
    }
}
