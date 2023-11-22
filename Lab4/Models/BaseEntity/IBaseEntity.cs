namespace Lab4.Models.BaseEntity
{
    public interface IBaseEntity
    {
        Guid Id { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
    }
}
