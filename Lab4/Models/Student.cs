namespace Lab4.Models
{
    public class Student : BaseEntity.BaseEntity
    {
        public string Name {  get; set; }
        public int Age { get; set; }
        public bool IsDeleted { get; set; }
    }
}
