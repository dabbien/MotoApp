namespace MotoApp.Entities
{
    public class BusinessPartner : EntityBase
    {
        public string? Name { get; set; }
        public override string ToString() => $"ID: {ID}. Name: {Name}";
    }
}
