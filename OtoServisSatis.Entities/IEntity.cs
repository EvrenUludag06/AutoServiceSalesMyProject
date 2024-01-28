namespace OtoServisSatis.Entities
{
    public interface IEntity
    {
        public int Id { get; set; }
        public bool? IsDelete { get; set; }
    }
}