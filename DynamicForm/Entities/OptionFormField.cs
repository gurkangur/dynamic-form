namespace DynamicForm.Entities
{
    public class OptionFormField
    {
        public int Id { get; set; }
        public int FormFieldId { get; set; }
        public FormField FormField { get; set; }
        public int OptionId { get; set; }
        public Option Option { get; set; }
        public int Index { get; set; }
        public bool IsActive { get; set; }
    }
}
